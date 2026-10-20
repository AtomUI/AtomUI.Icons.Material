import importlib.util
import json
import subprocess
import sys
import tempfile
import unittest
import zipfile
from pathlib import Path


SCRIPT = Path(__file__).resolve().parents[1] / "validate_nupkg.py"


class PackageValidationTests(unittest.TestCase):
    def setUp(self):
        self.temporary = tempfile.TemporaryDirectory()
        self.addCleanup(self.temporary.cleanup)
        self.directory = Path(self.temporary.name)

    def package(self, *, version="6.2.7", dependency="6.2.7", package_id="AtomUI.Icons.Material", missing=None, extra=None, malformed=False):
        path = self.directory / "AtomUI.Icons.Material.6.2.7.nupkg"
        nuspec = f'''<package><metadata><id>{package_id}</id><version>{version}</version>
          <repository commit="{'a' * 40}" />
          <dependencies><group targetFramework="net8.0"><dependency id="AtomUI.Core" version="{dependency}" /></group>
          <group targetFramework="net10.0"><dependency id="AtomUI.Core" version="{dependency}" /></group></dependencies>
          </metadata></package>'''
        files = {
            "AtomUI.Icons.Material.nuspec": "not xml" if malformed else nuspec,
            "lib/net8.0/AtomUI.Icons.Material.dll": b"MZ-net8-fixture",
            "lib/net10.0/AtomUI.Icons.Material.dll": b"MZ-net10-fixture",
            "LICENSE": "license", "README.nuget.md": "readme", "logo.png": b"icon",
        }
        if missing:
            del files[missing]
        files.update(extra or {})
        with zipfile.ZipFile(path, "w") as archive:
            for name, content in files.items():
                archive.writestr(name, content)
        return path

    def run_validator(self, path):
        return subprocess.run([
            sys.executable, str(SCRIPT), str(path), "--expected-version", "6.2.7",
            "--expected-atomui-version", "6.2.7", "--expected-commit", "a" * 40,
        ], capture_output=True, text=True)

    def test_accepts_only_the_expected_package_and_reports_its_checksum(self):
        import hashlib
        path = self.package()
        result = self.run_validator(path)
        self.assertEqual(0, result.returncode, result.stderr)
        report = json.loads(result.stdout)
        self.assertEqual("AtomUI.Icons.Material", report["package_id"])
        self.assertEqual("6.2.7", report["version"])
        self.assertEqual(["net10.0", "net8.0"], report["frameworks"])
        self.assertEqual(hashlib.sha256(path.read_bytes()).hexdigest(), report["sha256"])

    def test_rejects_wrong_identity_version_or_dependency(self):
        for changes in ({"version": "6.2.6"}, {"package_id": "Other"}, {"dependency": "6.2.6"}):
            with self.subTest(changes=changes):
                self.assertNotEqual(0, self.run_validator(self.package(**changes)).returncode)

    def test_accepts_the_deterministic_nuget_core_properties_entry(self):
        path = self.package(extra={
            "package/services/metadata/core-properties/nuget.psmdcp": "<coreProperties />",
        })
        result = self.run_validator(path)
        self.assertEqual(0, result.returncode, result.stderr)

    def test_rejects_missing_framework_or_package_resources(self):
        for missing in ("lib/net8.0/AtomUI.Icons.Material.dll", "lib/net10.0/AtomUI.Icons.Material.dll", "LICENSE", "README.nuget.md", "logo.png"):
            with self.subTest(missing=missing):
                self.assertNotEqual(0, self.run_validator(self.package(missing=missing)).returncode)

    def test_rejects_gallery_generator_temporary_and_traversal_entries(self):
        for name in ("gallery/example.axaml", "tools/Generator.dll", "temp/file.tmp", "../outside", "lib/net9.0/AtomUI.Icons.Material.dll"):
            with self.subTest(name=name):
                self.assertNotEqual(0, self.run_validator(self.package(extra={name: "unexpected"})).returncode)

    def test_rejects_malformed_nuspec_and_wrong_source_commit(self):
        self.assertNotEqual(0, self.run_validator(self.package(malformed=True)).returncode)
        path = self.package()
        result = subprocess.run([sys.executable, str(SCRIPT), str(path), "--expected-version", "6.2.7", "--expected-atomui-version", "6.2.7", "--expected-commit", "b" * 40], capture_output=True, text=True)
        self.assertNotEqual(0, result.returncode)

    def test_rejects_multiple_packages_in_release_directory(self):
        self.assertTrue(SCRIPT.exists(), "release package validator is not implemented")
        spec = importlib.util.spec_from_file_location("validate_nupkg", SCRIPT)
        module = importlib.util.module_from_spec(spec)
        sys.modules[spec.name] = module
        spec.loader.exec_module(module)
        path = self.package()
        (self.directory / "stale.nupkg").write_bytes(path.read_bytes())
        with self.assertRaises(ValueError):
            module.find_single_package(self.directory)


if __name__ == "__main__":
    unittest.main()
