import hashlib
import json
import os
import shutil
import subprocess
import sys
import tempfile
import textwrap
import unittest
import zipfile
from pathlib import Path


REPOSITORY = Path(__file__).resolve().parents[3]
WORKFLOW = REPOSITORY / ".github/workflows/release-material.yml"


@unittest.skipUnless(shutil.which("pwsh"), "PowerShell is required to execute the release workflow step")
class ReleaseWorkflowTests(unittest.TestCase):
    def setUp(self):
        self.temporary = tempfile.TemporaryDirectory()
        self.addCleanup(self.temporary.cleanup)
        self.directory = Path(self.temporary.name)
        packages = self.directory / "material-nuget"
        packages.mkdir()
        self.package = packages / "AtomUI.Icons.Material.6.2.7.nupkg"
        nuspec = f'''<package><metadata><id>AtomUI.Icons.Material</id><version>6.2.7</version>
          <repository commit="{'a' * 40}" />
          <dependencies><group targetFramework="net8.0"><dependency id="AtomUI.Core" version="6.2.7" /></group>
          <group targetFramework="net10.0"><dependency id="AtomUI.Core" version="6.2.7" /></group></dependencies>
          </metadata></package>'''
        with zipfile.ZipFile(self.package, "w") as archive:
            for name, contents in {
                "AtomUI.Icons.Material.nuspec": nuspec,
                "lib/net8.0/AtomUI.Icons.Material.dll": b"MZ-net8-fixture",
                "lib/net10.0/AtomUI.Icons.Material.dll": b"MZ-net10-fixture",
                "LICENSE": "license", "README.nuget.md": "readme", "logo.png": b"logo",
            }.items():
                archive.writestr(name, contents)
        checksum = hashlib.sha256(self.package.read_bytes()).hexdigest()
        (packages / "SHA256SUMS").write_text(f"{checksum}  {self.package.name}\n", encoding="ascii")

    def run_publish_step(self, *, push_exit_code=0):
        step = WORKFLOW.read_text(encoding="utf-8").split(
            "      - name: Verify downloaded artifact and publish without rebuilding\n", 1
        )[1]
        script = textwrap.dedent(step.split("        run: |\n", 1)[1])
        harness = r'''
$ErrorActionPreference = 'Stop'
$global:audit = @{push_count = 0; push_args = @(); requests = 0; sleeps = 0}
Set-Alias -Name python -Value $env:TEST_PYTHON
function dotnet {
    $global:audit.push_count++
    $global:audit.push_args = @($args)
    $global:LASTEXITCODE = [int]$env:TEST_PUSH_EXIT_CODE
}
function Invoke-RestMethod {
    $global:audit.requests++
    throw 'Post-upload network checks are not allowed in this test'
}
function Start-Sleep {
    $global:audit.sleeps++
    throw 'Post-upload indexing waits are not allowed in this test'
}
try { & {
''' + script + r'''
} } finally {
    Write-Output ('AUDIT:' + ($global:audit | ConvertTo-Json -Compress))
}
'''
        environment = dict(os.environ, RUNNER_TEMP=str(self.directory), VERSION="6.2.7",
                           ATOMUI_VERSION="6.2.7", SOURCE_REF="a" * 40,
                           NUGET_API_KEY="test-only-key", TEST_PYTHON=sys.executable,
                           TEST_PUSH_EXIT_CODE=str(push_exit_code))
        result = subprocess.run(
            ["pwsh", "-NoLogo", "-NoProfile", "-NonInteractive", "-Command", harness],
            cwd=REPOSITORY, env=environment, capture_output=True, text=True, timeout=30,
        )
        audit = json.loads(next(line.removeprefix("AUDIT:") for line in result.stdout.splitlines()
                                if line.startswith("AUDIT:")))
        return result, audit

    def test_successful_upload_completes_without_nuget_visibility_checks(self):
        result, audit = self.run_publish_step()
        self.assertEqual(0, result.returncode, result.stdout + result.stderr)
        self.assertEqual(1, audit["push_count"])
        self.assertEqual([
            "nuget", "push", str(self.package), "--api-key", "test-only-key",
            "--source", "https://api.nuget.org/v3/index.json",
        ], audit["push_args"])
        self.assertEqual(0, audit["requests"])
        self.assertEqual(0, audit["sleeps"])

    def test_failed_upload_fails_without_retrying_or_polling_nuget(self):
        result, audit = self.run_publish_step(push_exit_code=37)
        self.assertNotEqual(0, result.returncode)
        self.assertEqual(1, audit["push_count"])
        self.assertEqual(0, audit["requests"])
        self.assertEqual(0, audit["sleeps"])

    def test_checksum_mismatch_blocks_upload(self):
        self.package.write_bytes(b"tampered package")
        result, audit = self.run_publish_step()
        self.assertNotEqual(0, result.returncode)
        self.assertEqual(0, audit["push_count"])
        self.assertEqual(0, audit["requests"])
        self.assertEqual(0, audit["sleeps"])


if __name__ == "__main__":
    unittest.main()
