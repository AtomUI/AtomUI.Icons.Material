import io
import json
import sys
import unittest
import zipfile
from pathlib import Path


RELEASE_DIR = Path(__file__).resolve().parents[1]
sys.path.insert(0, str(RELEASE_DIR))

from resolve_release_version import COHORT_PACKAGES, ReleaseDecision, main, resolve_release


class ReleaseResolverTests(unittest.TestCase):
    def test_material_behind_requires_exact_core_candidate(self):
        fetch_json, fetch_bytes = self._nuget_fakes(material_versions=["6.1.3"])

        decision = resolve_release(fetch_json=fetch_json, fetch_bytes=fetch_bytes)

        self.assertEqual(
            ReleaseDecision(
                status="release-required",
                atomui_version="6.2.6",
                material_version="6.1.3",
                target_version="6.2.6",
                avalonia_version="12.1.4",
                missing_packages=(),
                reason="AtomUI.Icons.Material 6.1.3 is behind AtomUI 6.2.6.",
            ),
            decision,
        )
        output = io.StringIO()
        self.assertEqual(0, main([], fetch_json=fetch_json, fetch_bytes=fetch_bytes, stdout=output))
        self.assertEqual("release-required", json.loads(output.getvalue())["status"])

    def test_aligned_is_noop(self):
        fetch_json, fetch_bytes = self._nuget_fakes(material_versions=["6.2.6"])

        decision = resolve_release(fetch_json=fetch_json, fetch_bytes=fetch_bytes)

        self.assertEqual("aligned", decision.status)
        self.assertEqual("6.2.6", decision.atomui_version)
        self.assertEqual("6.2.6", decision.material_version)
        self.assertEqual("6.2.6", decision.target_version)
        self.assertEqual("12.1.4", decision.avalonia_version)
        self.assertEqual((), decision.missing_packages)
        self.assertEqual("AtomUI.Icons.Material is already aligned with AtomUI 6.2.6.", decision.reason)
        self.assertEqual(0, main([], fetch_json=fetch_json, fetch_bytes=fetch_bytes, stdout=io.StringIO()))

    def test_material_ahead_blocks(self):
        fetch_json, fetch_bytes = self._nuget_fakes(material_versions=["6.3.0"])

        decision = resolve_release(fetch_json=fetch_json, fetch_bytes=fetch_bytes)

        self.assertEqual("blocked", decision.status)
        self.assertEqual("6.2.6", decision.atomui_version)
        self.assertEqual("6.3.0", decision.material_version)
        self.assertIsNone(decision.target_version)
        self.assertEqual("12.1.4", decision.avalonia_version)
        self.assertEqual((), decision.missing_packages)
        self.assertEqual(
            "AtomUI.Icons.Material 6.3.0 is ahead of AtomUI 6.2.6.",
            decision.reason,
        )
        self.assertEqual(2, main([], fetch_json=fetch_json, fetch_bytes=fetch_bytes, stdout=io.StringIO()))

    def test_partial_rollout_blocks_without_falling_back(self):
        versions = {package: ["6.2.5", "6.2.6"] for package in COHORT_PACKAGES}
        versions["AtomUI.Generator"] = ["6.2.5"]
        fetch_json, fetch_bytes = self._nuget_fakes(
            package_versions=versions,
            material_versions=["6.1.3"],
        )

        decision = resolve_release(fetch_json=fetch_json, fetch_bytes=fetch_bytes)

        self.assertEqual("blocked", decision.status)
        self.assertEqual("6.2.6", decision.atomui_version)
        self.assertEqual("6.1.3", decision.material_version)
        self.assertIsNone(decision.target_version)
        self.assertIsNone(decision.avalonia_version)
        self.assertEqual(("AtomUI.Generator",), decision.missing_packages)
        self.assertEqual(
            "AtomUI 6.2.6 is not available in every required package.",
            decision.reason,
        )

    def test_prerelease_is_ignored(self):
        versions = {
            package: ["6.2.6", "6.3.0-beta.1"] for package in COHORT_PACKAGES
        }
        fetch_json, fetch_bytes = self._nuget_fakes(
            package_versions=versions,
            material_versions=["6.1.3", "6.3.0-preview.2"],
        )

        decision = resolve_release(fetch_json=fetch_json, fetch_bytes=fetch_bytes)

        self.assertEqual("release-required", decision.status)
        self.assertEqual("6.2.6", decision.target_version)
        self.assertEqual("6.1.3", decision.material_version)

    def test_core_nuspec_supplies_one_avalonia_version(self):
        nuspec = self._core_nupkg(
            """
            <group targetFramework="net8.0">
              <dependency id="Avalonia" version="[12.1.4]" />
            </group>
            <group targetFramework="net10.0">
              <dependency id="Avalonia" version="12.1.4" />
            </group>
            """
        )
        fetch_json, _ = self._nuget_fakes(material_versions=["6.1.3"])

        decision = resolve_release(fetch_json=fetch_json, fetch_bytes=lambda _: nuspec)

        self.assertEqual("release-required", decision.status)
        self.assertEqual("12.1.4", decision.avalonia_version)

    def test_network_or_malformed_payload_blocks(self):
        with self.subTest("network failure"):
            decision = resolve_release(
                fetch_json=lambda _: (_ for _ in ()).throw(OSError("offline")),
                fetch_bytes=lambda _: b"",
            )
            self.assertEqual("blocked", decision.status)
            self.assertIn("offline", decision.reason)
            self.assertEqual(2, main([], fetch_json=lambda _: (_ for _ in ()).throw(OSError("offline")), fetch_bytes=lambda _: b"", stdout=io.StringIO()))

        with self.subTest("malformed version index"):
            decision = resolve_release(
                fetch_json=lambda _: {"versions": ["not-semver"]},
                fetch_bytes=lambda _: b"",
            )
            self.assertEqual("blocked", decision.status)
            self.assertIn("stable semantic version", decision.reason)

        with self.subTest("missing Avalonia dependency"):
            fetch_json, _ = self._nuget_fakes(material_versions=["6.1.3"])
            decision = resolve_release(
                fetch_json=fetch_json,
                fetch_bytes=lambda _: self._core_nupkg(""),
            )
            self.assertEqual("blocked", decision.status)
            self.assertIn("Avalonia", decision.reason)

    @classmethod
    def _nuget_fakes(
        cls,
        material_versions,
        package_versions=None,
    ):
        package_versions = package_versions or {
            package: ["6.2.5", "6.2.6"] for package in COHORT_PACKAGES
        }
        indexes = {
            package.lower(): {"versions": versions}
            for package, versions in package_versions.items()
        }
        indexes["atomui.icons.material"] = {"versions": material_versions}

        def fetch_json(url):
            package_id = url.rstrip("/").split("/")[-2]
            return indexes[package_id]

        nupkg = cls._core_nupkg(
            '<dependency id="Avalonia" version="[12.1.4]" />'
        )
        return fetch_json, lambda _: nupkg

    @staticmethod
    def _core_nupkg(dependencies):
        nuspec = f"""<?xml version="1.0"?>
        <package xmlns="http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd">
          <metadata>
            <id>AtomUI.Core</id>
            <version>6.2.6</version>
            <dependencies>{dependencies}</dependencies>
          </metadata>
        </package>
        """
        buffer = io.BytesIO()
        with zipfile.ZipFile(buffer, "w") as archive:
            archive.writestr("AtomUI.Core.nuspec", nuspec)
        return buffer.getvalue()


if __name__ == "__main__":
    unittest.main()
