import json
import subprocess
import unittest
from pathlib import Path


REPOSITORY = Path(__file__).resolve().parents[3]


class BuildOutputPathsTests(unittest.TestCase):
    def test_projects_evaluate_to_the_shared_artifacts_layout(self):
        projects = (
            "src/AtomUI.Icons.Material/AtomUI.Icons.Material.csproj",
            "src/AtomUI.Icons.Material.Generator/AtomUI.Icons.Material.Generator.csproj",
            "gallery/MaterialGallery.Desktop/MaterialGallery.Desktop.csproj",
        )
        for project in projects:
            for configuration in ("Debug", "Release"):
                with self.subTest(project=project, configuration=configuration):
                    result = subprocess.run([
                        "dotnet", "msbuild", str(REPOSITORY / project), "-nologo",
                        f"-p:Configuration={configuration}", "-p:TargetFramework=net10.0",
                        "-getProperty:OutputPath,BaseIntermediateOutputPath,IntermediateOutputPath,PackageOutputPath",
                    ], capture_output=True, text=True, check=True)
                    actual = json.loads(result.stdout)["Properties"]
                    artifacts = REPOSITORY / ".artifacts"
                    intermediate = artifacts / Path(project).stem / "obj"
                    expected = {
                        "OutputPath": artifacts / "bin" / configuration / "net10.0",
                        "BaseIntermediateOutputPath": intermediate,
                        "IntermediateOutputPath": intermediate / configuration / "net10.0",
                        "PackageOutputPath": artifacts / "Nuget" / configuration,
                    }
                    for name, path in expected.items():
                        self.assertEqual(path.resolve(), Path(actual[name]).resolve(), name)


if __name__ == "__main__":
    unittest.main()
