# AtomUI Lockstep Release and Gallery Migration Design

## Summary

`AtomUI.Icons.Material` will follow AtomUI's latest stable NuGet version exactly. A request to “发布新版本” becomes an end-to-end release request: discover the latest coherent AtomUI release, update dependencies and the Material package version when behind, migrate or refresh the Gallery against that release's Gallery infrastructure, validate one immutable package artifact, and publish it to NuGet.org.

At design time, NuGet's V3 indexes report AtomUI's required package cohort at `6.2.6` and `AtomUI.Icons.Material` at `6.1.3`. The first release under this policy therefore targets `6.2.6`.

## Goals

- Keep `MaterialVersion` exactly aligned with the latest stable AtomUI version.
- Treat Gallery compatibility with the matching `AtomUI.Toolkits.GalleryBase` as a release requirement.
- Make version discovery deterministic and resistant to stale NuGet web search results.
- Publish exactly the package bytes that passed validation.
- Preserve user work and stop safely on partial upstream releases or ambiguous publication results.

## Non-goals

- Automatically follow prerelease AtomUI versions. Prereleases require an explicit request.
- Change the Material icon source set merely because AtomUI has released.
- Replace Material-specific icon browsing with GalleryBase's AntDesign-specific `IconGallery`.
- Publish when the required AtomUI package cohort is incomplete or the Gallery acceptance checks fail.

## Version Resolution Policy

The release resolver queries NuGet V3 flat-container indexes, filters out prerelease versions by default, and compares Semantic Versions.

The canonical AtomUI candidate is the newest stable version in the `AtomUI.Core` index. Every other required package must contain that exact version:

- `AtomUI.Core`
- `AtomUI.Desktop.Controls`
- `AtomUI.Generator`
- `AtomUI.Icons.Shared`
- `AtomUI.Toolkits.GalleryBase`

Requiring the exact `AtomUI.Core` candidate prevents an older common version from hiding a partially completed AtomUI rollout. The resolver also reads the `AtomUI.Icons.Material` index and produces one of four outcomes:

| Condition | Outcome |
|---|---|
| Material is behind AtomUI | Prepare a release at the AtomUI version |
| Material equals AtomUI | Report already aligned; do not republish |
| Material is ahead of AtomUI | Stop and report an inconsistent release state |
| No coherent AtomUI version exists | Stop and list the packages blocking the release |

For target version `T`, set both `AtomUIVersion` and `MaterialVersion` to `T`. Resolve `AvaloniaVersion` from the AtomUI `T` package dependency metadata and cross-check it against the matching AtomUI source tag; do not independently choose a newer Avalonia version.

A deterministic repository script will implement this query and emit machine-readable output containing the AtomUI cohort, current Material version, target version, Avalonia version, and decision. The `version-release` Skill will call the script rather than infer versions from search results.

## Gallery Architecture

The migration baseline is the clean Gallery implementation at AtomUIV6 tag `v6.2.6` (`6e75aeb452db0782721fdfd893053d90fb37e470`). Product-specific content will not be copied blindly.

### Composition root

`GalleryApplication.Configure(IAtomUIBuilder)` becomes the single AtomUI composition entry point. It configures the application ID, user theme directory, supported languages, initial theme, font, desktop controls, GalleryBase, Material Gallery control package, and main window. Desktop startup uses the current AtomUI platform-detection and ReactiveUI view-locator configuration patterns.

### Gallery module

A new `MaterialGalleryModule` owns a `GalleryBaseOptions` configuration:

- branding, logo, repository link, and version text read from assembly metadata;
- category navigation and the default route;
- route factories for Material icon pages;
- shell dimensions and platform behavior.

Version text derives from compiled `MaterialVersion` metadata so the Gallery cannot display a stale hard-coded version.

### Shell and navigation

The workspace adopts `GalleryWorkspaceViewModel`, `GalleryNavigationViewModel`, `GalleryShellView`, and the current GalleryBase title-bar/menu behavior. Theme, language, appearance, compact mode, motion, wave-spirit, route lifetime, and disposal logic come from GalleryBase instead of the project's duplicate workspace implementation.

Material icon categories become Gallery navigation entries. Selecting a category routes to a Material icon page. The icon theme selector remains a Material-specific sidebar/header action because Filled, Outlined, Rounded, Sharp, and TwoTone are domain state rather than application routes.

### Material-specific content

Retain and adapt the existing Material `IconInfoRepository`, `IconGallery`, `IconInfoItem`, icon theme resources, incremental loading, search, and copy-to-clipboard feedback. The GalleryBase `IconGallery` is not reused because it is coupled to `AntDesignIconCatalog`.

Remove the old custom shell, duplicated general-purpose workspace state, and obsolete Navigation themes only after the GalleryBase equivalents satisfy the existing interaction contract.

## Release Pipeline

The release workflow is split into immutable stages:

1. Resolve the target version and record the exact source commit.
2. Restore, generate, build, test, and pack once into a clean directory.
3. Validate the `.nupkg` metadata and contents, then upload it as the workflow artifact.
4. Require the publish job to download that artifact; it must not rebuild or repack.
5. Create an annotated `v<T>` tag on the validated commit, push the release commit and tag, verify the remote SHA, and publish the validated artifact.
6. Query NuGet.org after publication and report the observed version.

The phrase “发布新版本” authorizes the normal release sequence—release edits, release commit, annotated tag, branch/tag push, workflow dispatch, and NuGet publication—provided all gates pass. It does not authorize discarding unrelated changes, force-pushing, overwriting tags, or publishing a different artifact after validation.

If a push result is ambiguous, query NuGet before retrying. NuGet versions are immutable; never rebuild different bytes under the same version.

## Validation and Acceptance

### Automated

- Resolver tests cover stable filtering, prerelease exclusion, partial package rollout, already-aligned state, ahead-of-upstream state, and NuGet failures.
- Gallery configuration tests cover branding, version metadata, default route, category routes, and supported languages.
- Headless Gallery tests cover category navigation, all five icon themes, search, incremental loading, and copy behavior.
- Generator runs twice; the second run produces no tracked diff.
- Debug and Release solution builds succeed. Test output must distinguish “no tests discovered” from passing tests.
- Packing produces one expected `AtomUI.Icons.Material.<T>.nupkg`.
- Package inspection verifies ID, version, target frameworks, dependency versions, assemblies, resources, and absence of Gallery/generator/temp files.
- A temporary local-feed consumer restores, compiles, and references representative Material icons.

### Visual and interaction

Run the Gallery under its original desktop constraints and verify:

- sidebar and icon-theme selection;
- search and clear behavior;
- full-row hover and hit testing at left, center, and right positions;
- visible scrollbars, incremental loading, resizing, and scroll boundaries;
- light/dark, compact, motion, and language changes;
- icon click feedback and clipboard content.

The migration is not accepted if it removes or weakens an existing behavior merely to make the new shell compile.

## Change Boundaries

Expected areas include:

- `.agents/skills/version-release/`
- a deterministic release-version resolver and its tests under `scripts/`
- `build/Version.props` and `Directory.Packages.props`
- `gallery/MaterialGallery*`
- Gallery-focused tests
- `.github/workflows/release-material.yml`

The packaged library and generated Material icon API change only when required for AtomUI compatibility. Existing unrelated dirty-worktree changes remain untouched; implementation begins in an isolated worktree or from an explicitly reviewed change set.

## Current Release Decision

For the first execution of this design:

- target AtomUI and Material version: `6.2.6`;
- compatible Avalonia version: `12.1.4`;
- upstream Gallery baseline: AtomUIV6 `v6.2.6`;
- current Material NuGet version: `6.1.3`;
- Gallery migration and all acceptance gates are blockers for publishing `6.2.6`.
