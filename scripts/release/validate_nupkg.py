#!/usr/bin/env python3
"""Validate the exact Material package that will be published, without extracting it."""
from __future__ import annotations

import argparse
import hashlib
import json
import re
import sys
import zipfile
from dataclasses import asdict, dataclass
from pathlib import Path
from xml.etree import ElementTree

PACKAGE_ID = "AtomUI.Icons.Material"
FRAMEWORKS = ("net10.0", "net8.0")


@dataclass(frozen=True)
class PackageReport:
    package_id: str
    version: str
    atomui_version: str
    frameworks: tuple[str, ...]
    repository_commit: str
    sha256: str
    files: tuple[str, ...]


def find_single_package(directory: Path) -> Path:
    packages = sorted(Path(directory).glob("*.nupkg"))
    if len(packages) != 1:
        raise ValueError(f"Expected one nupkg in {directory}, found {len(packages)}")
    return packages[0]


def validate_package(path: Path, expected_version: str, expected_atomui_version: str,
                     expected_commit: str | None = None) -> PackageReport:
    path = Path(path)
    if path.name.lower() != f"{PACKAGE_ID}.{expected_version}.nupkg".lower():
        raise ValueError("Unexpected package filename")
    with zipfile.ZipFile(path) as archive:
        names = archive.namelist()
        if len(names) != len(set(names)):
            raise ValueError("Duplicate archive entries are forbidden")
        required = {f"{PACKAGE_ID}.nuspec", "LICENSE", "README.nuget.md", "logo.png"}
        required.update(f"lib/{framework}/{PACKAGE_ID}.dll" for framework in FRAMEWORKS)
        if not required.issubset(names):
            raise ValueError(f"Missing package files: {sorted(required.difference(names))}")
        for name in names:
            if name in required or name in {"_rels/.rels", "[Content_Types].xml", ".signature.p7s"}:
                continue
            if re.fullmatch(r"package/services/metadata/core-properties/[0-9a-f]+\.psmdcp", name):
                continue
            if name in {f"lib/{framework}/{PACKAGE_ID}.xml" for framework in FRAMEWORKS}:
                continue
            raise ValueError(f"Unexpected package entry: {name}")
        if archive.testzip() is not None:
            raise ValueError("Corrupt archive entry")
        for framework in FRAMEWORKS:
            if not archive.read(f"lib/{framework}/{PACKAGE_ID}.dll").startswith(b"MZ"):
                raise ValueError(f"Invalid assembly for {framework}")
        root = ElementTree.fromstring(archive.read(f"{PACKAGE_ID}.nuspec"))
    for element in root.iter():
        element.tag = element.tag.rsplit("}", 1)[-1]
    metadata = root.find("metadata")
    if metadata is None:
        raise ValueError("Missing package metadata")
    if metadata.findtext("id") != PACKAGE_ID or metadata.findtext("version") != expected_version:
        raise ValueError("Package ID or version does not match the release")
    groups = metadata.findall("dependencies/group")
    if sorted(group.get("targetFramework", "") for group in groups) != sorted(FRAMEWORKS):
        raise ValueError("Dependency target frameworks must be net8.0 and net10.0")
    for group in groups:
        dependencies = group.findall("dependency")
        if len(dependencies) != 1 or dependencies[0].get("id") != "AtomUI.Core":
            raise ValueError("Every framework must depend only on AtomUI.Core")
        if dependencies[0].get("version") not in {expected_atomui_version, f"[{expected_atomui_version}]"}:
            raise ValueError("AtomUI.Core dependency is not aligned with the release")
    repository = metadata.find("repository")
    commit = repository.get("commit", "") if repository is not None else ""
    if expected_commit is not None and commit.lower() != expected_commit.lower():
        raise ValueError("Package source commit does not match the verified candidate")
    return PackageReport(PACKAGE_ID, expected_version, expected_atomui_version,
                         FRAMEWORKS, commit, hashlib.sha256(path.read_bytes()).hexdigest(),
                         tuple(sorted(names)))


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("package", type=Path)
    parser.add_argument("--expected-version", required=True)
    parser.add_argument("--expected-atomui-version", required=True)
    parser.add_argument("--expected-commit")
    args = parser.parse_args()
    try:
        path = find_single_package(args.package) if args.package.is_dir() else args.package
        report = validate_package(path, args.expected_version, args.expected_atomui_version, args.expected_commit)
    except (OSError, ValueError, zipfile.BadZipFile, ElementTree.ParseError) as error:
        print(f"Package validation failed: {error}", file=sys.stderr)
        return 1
    print(json.dumps(asdict(report), indent=2))
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
