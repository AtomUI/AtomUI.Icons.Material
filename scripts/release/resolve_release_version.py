#!/usr/bin/env python3
"""Resolve the next AtomUI.Icons.Material release from NuGet V3 metadata."""

from __future__ import annotations

import argparse
import io
import json
import re
import sys
import urllib.request
import zipfile
from dataclasses import asdict, dataclass
from typing import Any, Callable, Optional, Sequence, Tuple
from xml.etree import ElementTree


FLAT_CONTAINER = "https://api.nuget.org/v3-flatcontainer"
COHORT_PACKAGES = (
    "AtomUI.Core",
    "AtomUI.Desktop.Controls",
    "AtomUI.Generator",
    "AtomUI.Icons.Shared",
    "AtomUI.Toolkits.GalleryBase",
)
MATERIAL_PACKAGE = "AtomUI.Icons.Material"
_STABLE_VERSION = re.compile(r"^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)$")
_PRERELEASE_VERSION = re.compile(
    r"^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)"
    r"-[0-9A-Za-z-]+(?:\.[0-9A-Za-z-]+)*(?:\+[0-9A-Za-z.-]+)?$"
)


@dataclass(frozen=True)
class ReleaseDecision:
    status: str
    atomui_version: Optional[str]
    material_version: Optional[str]
    target_version: Optional[str]
    avalonia_version: Optional[str]
    missing_packages: Tuple[str, ...]
    reason: str


def _default_fetch_json(url: str) -> Any:
    with urllib.request.urlopen(url, timeout=30) as response:
        return json.load(response)


def _default_fetch_bytes(url: str) -> bytes:
    with urllib.request.urlopen(url, timeout=30) as response:
        return response.read()


def _index_url(package_id: str) -> str:
    return f"{FLAT_CONTAINER}/{package_id.lower()}/index.json"


def _nupkg_url(package_id: str, version: str) -> str:
    lowered = package_id.lower()
    return f"{FLAT_CONTAINER}/{lowered}/{version}/{lowered}.{version}.nupkg"


def _stable_versions(payload: Any, package_id: str) -> Tuple[str, ...]:
    if not isinstance(payload, dict) or not isinstance(payload.get("versions"), list):
        raise ValueError(f"{package_id} returned a malformed version index")

    stable = []
    for value in payload["versions"]:
        if not isinstance(value, str):
            raise ValueError(f"{package_id} returned an invalid version value")
        if _STABLE_VERSION.fullmatch(value):
            stable.append(value)
        elif not _PRERELEASE_VERSION.fullmatch(value):
            raise ValueError(
                f"{package_id} returned invalid stable semantic version {value!r}"
            )

    if not stable:
        raise ValueError(f"{package_id} has no stable semantic version")
    return tuple(stable)


def _version_key(version: str) -> Tuple[int, int, int]:
    match = _STABLE_VERSION.fullmatch(version)
    if match is None:
        raise ValueError(f"Invalid stable semantic version {version!r}")
    return tuple(int(part) for part in match.groups())


def _avalonia_version(nupkg: bytes) -> str:
    try:
        with zipfile.ZipFile(io.BytesIO(nupkg)) as archive:
            nuspec_names = [name for name in archive.namelist() if name.lower().endswith(".nuspec")]
            if len(nuspec_names) != 1:
                raise ValueError("AtomUI.Core package must contain exactly one nuspec")
            root = ElementTree.fromstring(archive.read(nuspec_names[0]))
    except (zipfile.BadZipFile, ElementTree.ParseError, KeyError) as error:
        raise ValueError(f"AtomUI.Core package metadata is malformed: {error}") from error

    versions = set()
    for dependency in root.iter():
        if dependency.tag.rsplit("}", 1)[-1] != "dependency":
            continue
        if dependency.attrib.get("id", "").lower() != "avalonia":
            continue
        value = dependency.attrib.get("version", "").strip()
        if value.startswith("[") and value.endswith("]") and "," not in value:
            value = value[1:-1]
        if not _STABLE_VERSION.fullmatch(value):
            raise ValueError(f"AtomUI.Core has a non-exact Avalonia dependency {value!r}")
        versions.add(value)

    if len(versions) != 1:
        raise ValueError("AtomUI.Core must supply one exact Avalonia dependency version")
    return versions.pop()


def resolve_release(
    *,
    fetch_json: Callable[[str], Any] = _default_fetch_json,
    fetch_bytes: Callable[[str], bytes] = _default_fetch_bytes,
) -> ReleaseDecision:
    try:
        indexes = {
            package: _stable_versions(fetch_json(_index_url(package)), package)
            for package in (*COHORT_PACKAGES, MATERIAL_PACKAGE)
        }
        atomui_version = max(indexes["AtomUI.Core"], key=_version_key)
        material_version = max(indexes[MATERIAL_PACKAGE], key=_version_key)

        missing = tuple(
            package
            for package in COHORT_PACKAGES
            if atomui_version not in indexes[package]
        )
        if missing:
            return ReleaseDecision(
                status="blocked",
                atomui_version=atomui_version,
                material_version=material_version,
                target_version=None,
                avalonia_version=None,
                missing_packages=missing,
                reason=f"AtomUI {atomui_version} is not available in every required package.",
            )

        avalonia_version = _avalonia_version(
            fetch_bytes(_nupkg_url("AtomUI.Core", atomui_version))
        )
        atomui_key = _version_key(atomui_version)
        material_key = _version_key(material_version)
        if material_key > atomui_key:
            return ReleaseDecision(
                status="blocked",
                atomui_version=atomui_version,
                material_version=material_version,
                target_version=None,
                avalonia_version=avalonia_version,
                missing_packages=(),
                reason=(
                    f"AtomUI.Icons.Material {material_version} is ahead of "
                    f"AtomUI {atomui_version}."
                ),
            )

        if material_key == atomui_key:
            status = "aligned"
            reason = f"AtomUI.Icons.Material is already aligned with AtomUI {atomui_version}."
        else:
            status = "release-required"
            reason = (
                f"AtomUI.Icons.Material {material_version} is behind "
                f"AtomUI {atomui_version}."
            )
        return ReleaseDecision(
            status=status,
            atomui_version=atomui_version,
            material_version=material_version,
            target_version=atomui_version,
            avalonia_version=avalonia_version,
            missing_packages=(),
            reason=reason,
        )
    except Exception as error:
        return ReleaseDecision(
            status="blocked",
            atomui_version=None,
            material_version=None,
            target_version=None,
            avalonia_version=None,
            missing_packages=(),
            reason=f"Release metadata could not be resolved: {error}",
        )


def main(
    argv: Optional[Sequence[str]] = None,
    *,
    fetch_json: Callable[[str], Any] = _default_fetch_json,
    fetch_bytes: Callable[[str], bytes] = _default_fetch_bytes,
    stdout: Any = sys.stdout,
) -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.parse_args(argv)
    decision = resolve_release(fetch_json=fetch_json, fetch_bytes=fetch_bytes)
    json.dump(asdict(decision), stdout, indent=2)
    stdout.write("\n")
    return 2 if decision.status == "blocked" else 0


if __name__ == "__main__":
    raise SystemExit(main())
