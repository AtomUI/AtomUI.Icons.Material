---
name: version-release
description: Use when preparing, reviewing, validating, tagging, or publishing an AtomUI.Icons.Material release, including requests to bump the package version or check release readiness.
---

# AtomUI.Icons.Material Version Release

## Release contract

- Treat “发布新版本” as an end-to-end release request: resolve the current upstream version, prepare and validate the aligned release, migrate the Gallery when required, commit, tag, push, dispatch the release workflow, and verify NuGet publication.
- Run `python3 scripts/release/resolve_release_version.py` before choosing a version. Use its machine-readable result; do not infer the version from search pages or memory.
- Stable releases require the exact newest stable `AtomUI.Core` version to exist in `AtomUI.Core`, `AtomUI.Desktop.Controls`, `AtomUI.Generator`, `AtomUI.Icons.Shared`, and `AtomUI.Toolkits.GalleryBase`. A partial rollout is `blocked`; never fall back to an older common version.
- When the resolver reports `release-required`, set both `AtomUIVersion` and `MaterialVersion` to `target_version` and set `AvaloniaVersion` to the resolver's `avalonia_version`. When it reports `aligned`, do not republish. Stop on `blocked`.
- Gallery compatibility with the matching `AtomUI.Toolkits.GalleryBase` infrastructure is a release gate. Preserve Material's five icon themes, categories, search, incremental loading, scrolling, full-width hit testing, and copy feedback.

## Safety contract

- Inspect `git status`, branch/upstream, tags, and `git log <previous-tag>..HEAD` first. Never discard, stash, stage, or mix unrelated user changes. Use a clean worktree when the release set cannot be isolated safely.
- For requests other than “发布新版本”, confirm whether work stops at preparation or includes commit, tag, push, workflow dispatch, and NuGet publication. A published NuGet version is immutable.
- Never force-push, overwrite a tag, or publish different bytes after validation. After an ambiguous push, query NuGet before retrying.

## Repository facts

| Item | Source of truth |
|---|---|
| Package version | `MaterialVersion` in `build/Version.props` |
| Dependency versions | `AtomUIVersion` and `AvaloniaVersion` in `build/Version.props` |
| Published project | `src/AtomUI.Icons.Material/AtomUI.Icons.Material.csproj` |
| Release workflow | `.github/workflows/release-material.yml` |
| Version resolver | `scripts/release/resolve_release_version.py` |

## Release workflow

1. Compare the release range with the previous tag. Classify public API removals/renames/signature changes, icon removals or renames, target-framework changes, and higher minimum dependency versions. If the requested SemVer level is incompatible with the findings, stop and report it.
2. Review package metadata and all changed source, assets, generator code, and checked-in `GeneratedIcons`. Do not invent CHANGELOG, documentation, or validation requirements that this repository does not have.
3. When assets, generator code, or generated output changed, build the generator and run it from its output directory because it resolves repository paths from the current working directory:

   ```sh
   dotnet build src/AtomUI.Icons.Material.Generator/AtomUI.Icons.Material.Generator.csproj -c Release -f net10.0
   (cd .artifacts/bin/Release/net10.0 && dotnet AtomUI.Icons.Material.Generator.dll)
   ```

   Review the generated diff, then run it again and require no further diff.
4. Validate from the exact candidate commit:

   ```sh
   dotnet restore Material.slnx
   dotnet build Material.slnx -c Release --no-restore
   dotnet test Material.slnx -c Release --no-build
   dotnet pack src/AtomUI.Icons.Material/AtomUI.Icons.Material.csproj -c Release --no-build -o <clean-output-directory>
   ```

   Report honestly when no test projects are discovered.
5. Inspect the single expected `.nupkg`: filename, package ID/version, target frameworks, dependency versions, assemblies/resources, and absence of generator, gallery, temporary, or stale files. Prefer a local-feed consumer smoke test for changed public icons.
6. Before publication, confirm the version does not already exist on NuGet and the remote release branch still points to the verified commit. Rehearse the workflow with `PublishToNuget=false` and `SourceRef=<candidate-sha>`, then validate the downloaded package and checksum.
7. For an authorized end-to-end release, create an annotated `v<version>` tag on the verified commit, push the release branch and tag, re-check both remote SHAs, then dispatch publication with the same `SourceRef`. Confirm NuGet exposes the target version.

## Handoff

Report the audited commit range, compatibility verdict, changed version fields, verification commands/results, package path and metadata, remaining manual steps, and every external action actually performed.
