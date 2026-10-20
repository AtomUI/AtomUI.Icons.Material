# AtomUI Lockstep Release and Gallery Migration Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Align `AtomUI.Icons.Material` with AtomUI `6.2.6`, rebuild the Gallery on AtomUI's `v6.2.6` GalleryBase infrastructure, and publish one validated immutable `6.2.6` package.

**Architecture:** A deterministic NuGet V3 resolver decides whether a release is required and supplies the exact AtomUI/Avalonia versions. `MaterialGalleryModule` composes GalleryBase routing and branding while Material-specific icon browsing remains local. GitHub Actions builds, validates, uploads, and publishes one package artifact without repacking.

**Tech Stack:** .NET 10/.NET 8, Avalonia 12.1.4, AtomUI 6.2.6, ReactiveUI, AtomUI.Toolkits.GalleryBase, xUnit v3, Shouldly, Python 3 standard library, GitHub Actions, NuGet V3 API.

**Spec:** `docs/superpowers/specs/2026-10-19-atomui-lockstep-release-gallery-migration-design.md`

## Global Constraints

- Stable releases only unless the user explicitly requests a prerelease.
- `AtomUIVersion` and `MaterialVersion` must both equal `6.2.6`; `AvaloniaVersion` must equal `12.1.4`.
- The AtomUI cohort is `AtomUI.Core`, `AtomUI.Desktop.Controls`, `AtomUI.Generator`, `AtomUI.Icons.Shared`, and `AtomUI.Toolkits.GalleryBase`; every package must contain the exact `AtomUI.Core` candidate.
- Use AtomUIV6 tag `v6.2.6` (`6e75aeb452db0782721fdfd893053d90fb37e470`) as the Gallery infrastructure baseline.
- Preserve Filled, Outlined, Rounded, Sharp, and TwoTone browsing, category selection, search, incremental loading, scrolling, and copy feedback.
- Never discard, stash, stage, or overwrite unrelated existing worktree changes. Audit and selectively incorporate the in-progress AtomUI `6.2.6` changes.
- NuGet publication must use the exact package artifact validated by the publishing workflow; a version is never rebuilt after an ambiguous push.

## Review Focus

- Partial AtomUI rollout: a newer `AtomUI.Core` without the same version in every cohort package must block rather than fall back to an older common version (Task 1 test).
- Invalid upstream metadata: malformed indexes, missing Avalonia dependencies, and prerelease-only candidates must block without guessing a fallback version (Task 1 tests).
- Gallery input geometry: sidebar rows and icon items must remain hit-testable across their full width while scrollbars and incremental loading remain functional at 1300×900 and the minimum supported size (Task 5 tests and visual acceptance).
- Clipboard lifecycle: rapid clicks, missing clipboard, clipboard failure, and view detachment must not show a stale success notification or leak handlers (Task 5 tests).
- Artifact identity: the publish job must download and hash-check the build job artifact and must contain no build or pack command (Task 6 test).

---

### Task 1: Deterministic NuGet release resolver

**Files:**
- Create: `scripts/release/resolve_release_version.py`
- Create: `scripts/release/tests/test_resolve_release_version.py`

**Interfaces:**
- Produces: `ReleaseDecision(status, atomui_version, material_version, target_version, avalonia_version, missing_packages, reason)`.
- Produces: CLI JSON with status `release-required`, `aligned`, or `blocked`; exit `0` for the first two and `2` for blocked.
- Consumes: NuGet flat-container JSON and the `AtomUI.Core.<version>.nupkg` nuspec.

- [ ] **Step 1: Write failing resolver tests**

Add `unittest` cases named `test_material_behind_requires_exact_core_candidate`, `test_aligned_is_noop`, `test_material_ahead_blocks`, `test_partial_rollout_blocks_without_falling_back`, `test_prerelease_is_ignored`, `test_core_nuspec_supplies_one_avalonia_version`, and `test_network_or_malformed_payload_blocks`. Inject `fetch_json(url)` and `fetch_bytes(url)` fakes; assert the exact decision fields and exit semantics.

- [ ] **Step 2: Run the tests and confirm RED**

Run: `python3 -m unittest discover -s scripts/release/tests -p 'test_*.py' -v`

Expected: FAIL because `resolve_release_version` does not exist.

- [ ] **Step 3: Implement the resolver**

Implement strict stable `major.minor.patch` parsing, canonical-candidate selection from `AtomUI.Core`, exact cohort membership checks, Material comparison, nuspec extraction through `zipfile`, and JSON CLI output. Network, XML, missing dependency, and invalid-version failures return `blocked`, never a guessed version.

- [ ] **Step 4: Run resolver tests and a live read-only query**

Run:

```bash
python3 -m unittest discover -s scripts/release/tests -p 'test_*.py' -v
python3 scripts/release/resolve_release_version.py
```

Expected: tests PASS; live JSON reports AtomUI `6.2.6`, Material `6.1.3`, target `6.2.6`, Avalonia `12.1.4`, and `release-required`.

- [ ] **Step 5: Commit only resolver paths**

```bash
git add scripts/release/resolve_release_version.py scripts/release/tests/test_resolve_release_version.py
git commit -m "build: resolve AtomUI-aligned release versions"
```

### Task 2: Encode lockstep policy and align dependency configuration

**Files:**
- Modify: `.agents/skills/version-release/SKILL.md`
- Modify: `build/Version.props`
- Modify: `Directory.Packages.props`

**Interfaces:**
- Consumes: Task 1 CLI JSON.
- Produces: one `$(AtomUIVersion)` value for all AtomUI dependencies, including GalleryBase; `MaterialVersion=6.2.6`.

- [ ] **Step 1: Record and review the existing relevant diff**

Run `git diff -- build/Version.props Directory.Packages.props .agents/skills/version-release/SKILL.md` and classify every existing line as retained, replaced, or unrelated. Do not alter other dirty files in this step.

- [ ] **Step 2: Update the version policy Skill**

Make “发布新版本” invoke Task 1's resolver, require the coherent cohort, align `AtomUIVersion` and `MaterialVersion`, treat Gallery migration as a release gate, and preserve the commit/tag/push/NuGet safety rules. Remove the old instruction that normal releases change only `MaterialVersion`.

- [ ] **Step 3: Align central versions and add GalleryBase**

Set `AtomUIVersion` and `MaterialVersion` to `6.2.6`, retain `AvaloniaVersion=12.1.4`, and add `AtomUI.Toolkits.GalleryBase` at `$(AtomUIVersion)` in `Directory.Packages.props`.

- [ ] **Step 4: Validate configuration and Skill syntax**

Run:

```bash
python3 /Users/chinboy/.codex/skills/.system/skill-creator/scripts/quick_validate.py .agents/skills/version-release
dotnet restore Material.slnx
git diff --check -- .agents/skills/version-release/SKILL.md build/Version.props Directory.Packages.props
git diff --cached --name-only
```

Expected: Skill valid, restore succeeds, diff check is clean, and no pre-existing unrelated file is staged.

- [ ] **Step 5: Commit only policy and central-version files**

```bash
git add .agents/skills/version-release/SKILL.md build/Version.props Directory.Packages.props
git commit -m "build: align Material release policy with AtomUI"
```

### Task 3: Add Gallery test harness and product module

**Files:**
- Create: `tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj`
- Create: `tests/MaterialGallery.Tests/GlobalUsings.cs`
- Create: `tests/MaterialGallery.Tests/AvaloniaTestApp.cs`
- Create: `tests/MaterialGallery.Tests/MaterialGalleryModuleTests.cs`
- Create: `gallery/MaterialGallery/MaterialGalleryModule.cs`
- Create: `gallery/MaterialGallery/GalleryVersionInfo.cs`
- Create: `gallery/MaterialGallery/Workspace/ViewModels/MaterialIconPageViewModel.cs`
- Create: `gallery/MaterialGallery/Workspace/Views/MaterialIconPage.axaml`
- Create: `gallery/MaterialGallery/Workspace/Views/MaterialIconPage.axaml.cs`
- Modify: `gallery/MaterialGallery/MaterialGallery.csproj`
- Modify: `Material.slnx`
- Modify: `Directory.Packages.props`

**Interfaces:**
- Produces: `MaterialGalleryModule.Configure(GalleryBaseOptions)`, `CreateConfiguration()`, `GetConfiguration()`, and `RegisterViews(DefaultViewLocator)`.
- Produces: `GalleryVersionInfo.DisplayVersion` sourced from assembly metadata `MaterialVersion`.
- Produces: `MaterialIconPageViewModel(IScreen hostScreen, string category) : IRoutableViewModel` and its typed view for deferred category routes.

- [ ] **Step 1: Create the test project and failing module tests**

Target `net10.0`; reference `Avalonia.Headless`, `Microsoft.NET.Test.Sdk` `18.3.0`, `Shouldly` `4.3.0`, `xunit.v3` `3.2.2`, and `xunit.runner.visualstudio` `3.1.5`. Add the project to `Material.slnx`. Tests assert app name, `v6.2.6` display version, default `Action` route, one route per generated category, localized navigation headers, and exact view/view-model types.

- [ ] **Step 2: Run the module tests and confirm RED**

Run: `dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter FullyQualifiedName~MaterialGalleryModuleTests`

Expected: FAIL because `MaterialGalleryModule` and route types do not exist.

- [ ] **Step 3: Add GalleryBase package and version metadata**

Reference `AtomUI.Toolkits.GalleryBase` from `MaterialGallery.csproj`, add `AssemblyMetadata("MaterialVersion", "$(MaterialVersion)")`, and expose internals to `MaterialGallery.Tests`. The test project references `AtomUI.Generator` as an analyzer so its partial headless application receives generated startup registration.

- [ ] **Step 4: Implement the product module**

Configure branding from `GalleryVersionInfo`, build localized category navigation from `IconInfoRepository.Categories`, set `Action` as the default route, and register deferred `MaterialIconPageViewModel`/`MaterialIconPage` factories. The minimal page exposes its category but does not create icon controls or icon collections during configuration.

- [ ] **Step 5: Run module tests**

Run: `dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter FullyQualifiedName~MaterialGalleryModuleTests`

Expected: PASS.

- [ ] **Step 6: Commit the module and test harness**

```bash
git add Material.slnx Directory.Packages.props gallery/MaterialGallery/MaterialGallery.csproj gallery/MaterialGallery/MaterialGalleryModule.cs gallery/MaterialGallery/GalleryVersionInfo.cs gallery/MaterialGallery/Workspace/ViewModels/MaterialIconPageViewModel.cs gallery/MaterialGallery/Workspace/Views/MaterialIconPage.axaml gallery/MaterialGallery/Workspace/Views/MaterialIconPage.axaml.cs tests/MaterialGallery.Tests
git commit -m "feat: add Material GalleryBase product module"
```

### Task 4: Migrate startup, shell, and category navigation

**Files:**
- Create: `gallery/MaterialGallery/Workspace/ViewModels/CaseNavigationViewModel.cs`
- Create: `gallery/MaterialGallery/Workspace/Views/CaseNavigation.axaml`
- Create: `gallery/MaterialGallery/Workspace/Views/CaseNavigation.axaml.cs`
- Modify: `gallery/MaterialGallery.Desktop/Program.cs`
- Modify: `gallery/MaterialGallery.Desktop/GalleryApplication.cs`
- Modify: `gallery/MaterialGallery/BaseGalleryApplication.cs`
- Modify: `gallery/MaterialGallery/ThemeManagerBuilderExtensions.cs`
- Modify: `gallery/MaterialGallery/Workspace/ViewModels/WorkspaceWindowViewModel.cs`
- Modify: `gallery/MaterialGallery/Workspace/Views/WorkspaceWindow.axaml`
- Modify: `gallery/MaterialGallery/Workspace/Views/WorkspaceWindow.axaml.cs`
- Test: `tests/MaterialGallery.Tests/GalleryShellMigrationTests.cs`

**Interfaces:**
- Produces: `GalleryApplication.Configure(IAtomUIBuilder)` and `WorkspaceWindowViewModel : GalleryWorkspaceViewModel`.
- Produces: `CaseNavigationViewModel : GalleryNavigationViewModel` and a view implementing `IGallerySidebarNavMenuHost`.
- Produces: `WorkspaceWindowViewModel.IconTheme : IconThemeType`, shared by the navigation selector and every routed icon page.
- Consumes: Task 3 `MaterialGalleryModule` configuration and routes.

- [ ] **Step 1: Write failing migration tests**

Assert startup registers `MaterialGalleryModule.RegisterViews`, uses `UseAtomUIPlatformDetect` and `GalleryApplication.Configure`, the application configures languages/GalleryBase/main window, the workspace delegates general theme/language state to `GalleryWorkspaceViewModel`, and every category navigation node can route. Include a test that activating and disposing navigation does not retain event handlers.

- [ ] **Step 2: Run migration tests and confirm RED**

Run: `dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter FullyQualifiedName~GalleryShellMigrationTests`

Expected: FAIL against the legacy workspace and startup.

- [ ] **Step 3: Move AtomUI composition into `GalleryApplication.Configure`**

Follow AtomUIV6 `v6.2.6`: application ID, user theme directory, four languages, default theme, Alibaba font, desktop controls, `UseGalleryBase(MaterialGalleryModule.Configure)`, `UseGalleryControls()`, and `UseMainWindow`. Program configures the ReactiveUI view locator and calls `.UseAtomUI(GalleryApplication.Configure)`.

- [ ] **Step 4: Replace duplicated workspace behavior with GalleryBase shell types**

Make `WorkspaceWindowViewModel` derive from `GalleryWorkspaceViewModel`; construct `GalleryShellView` with `CaseNavigation`; use `GalleryWindowTitleBar`; preserve window options and initial/minimum dimensions. Add the shared `IconTheme` property with Filled as its default. Port only Material-specific title/icon behavior.

- [ ] **Step 5: Implement GalleryBase category navigation**

Populate the NavMenu through `GalleryNavigationMenuAdapter`, route categories through `GalleryNavigationViewModel`, and expose the five-value icon-theme selector as the sidebar header action. Ensure language changes rebuild localized headers and disposal detaches subscriptions.

- [ ] **Step 6: Run migration tests and the desktop build**

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter FullyQualifiedName~GalleryShellMigrationTests
dotnet build gallery/MaterialGallery.Desktop/MaterialGallery.Desktop.csproj -c Debug
```

Expected: tests PASS and desktop build succeeds.

- [ ] **Step 7: Commit startup and shell migration**

Stage only the files listed in this task and commit with `feat: migrate Material Gallery to GalleryBase shell`.

### Task 5: Route Material icon content and preserve interactions

> Superseded by `docs/superpowers/plans/2026-10-19-material-gallery-ux-refactor.md`, which implements the subsequently approved grouped category navigation, Overview, Community, icon-catalog layout, and visual acceptance contract. Complete that plan before continuing with Task 6 below.

**Files:**
- Modify: `gallery/MaterialGallery/Workspace/ViewModels/MaterialIconPageViewModel.cs`
- Modify: `gallery/MaterialGallery/Workspace/Views/MaterialIconPage.axaml`
- Modify: `gallery/MaterialGallery/Workspace/Views/MaterialIconPage.axaml.cs`
- Modify: `gallery/MaterialGallery/Controls/IconGallery/IconGallery.cs`
- Modify: `gallery/MaterialGallery/Controls/GalleryControlThemesProvider.axaml`
- Modify: `gallery/MaterialGallery/Models/IconInfoRepository.cs`
- Modify: `gallery/MaterialGallery/MaterialGalleryModule.cs`
- Delete: `gallery/MaterialGallery/Controls/Navigation/`
- Test: `tests/MaterialGallery.Tests/IconGalleryInteractionTests.cs`
- Test: `tests/MaterialGallery.Tests/IconGalleryGeometryTests.cs`

**Interfaces:**
- Produces: `MaterialIconPageViewModel(IScreen hostScreen, string category)` implementing `IRoutableViewModel`.
- Produces: routed `MaterialIconPage` that binds category plus shared icon-theme state to `IconInfoRepository`.
- Consumes: Task 4 workspace icon-theme selection.

- [ ] **Step 1: Write failing interaction and lifecycle tests**

Cover all five themes, category changes, case-insensitive search, initial 96 items, 96-item incremental batches, resetting scroll position on filter/category changes, and icon disposal when results reset. Cover rapid copy requests, missing clipboard, thrown clipboard operations, and detachment before completion; only the current successful request may show success.

- [ ] **Step 2: Write failing geometry tests**

At 1300×900 and GalleryBase's minimum size, arrange the shell and assert visible sidebar/content bounds, scrollbar visibility, non-zero viewport/extent, icon hit targets at left/center/right sample points, incremental loading near the bottom, and no overlay intercepting icon input.

- [ ] **Step 3: Run focused tests and confirm RED**

Run: `dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter "FullyQualifiedName~IconGalleryInteractionTests|FullyQualifiedName~IconGalleryGeometryTests"`

Expected: FAIL because routed content and required lifecycle behavior are absent.

- [ ] **Step 4: Implement routed Material icon pages**

Keep the Material repository/control rather than GalleryBase's AntDesign-specific icon control. Bind each category route to a deferred page/view-model, share the selected icon theme through the workspace, and move copy/message ownership into the routed page with cancellable, detach-safe behavior.

- [ ] **Step 5: Remove the legacy category Navigation control**

Delete its C#/AXAML/themes/tokens only after route navigation and icon-theme selection satisfy the tests. Remove its resource include, do not remove Material `IconGallery` themes, and do not edit `GeneratedFiles` by hand; Task 7 reconciles all generated output together.

- [ ] **Step 6: Run all Gallery tests**

Run: `dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug`

Expected: PASS with a non-zero test count.

- [ ] **Step 7: Perform scripted visual acceptance**

Use the `scripted-visual-acceptance` Skill against the desktop Gallery. Capture evidence for default and minimum sizes, category/theme/search transitions, full-row and icon hit testing, scrollbar visibility, incremental scrolling, light/dark/compact/language changes, and copy feedback. Do not accept a layout that removes scrolling or changes the established icon browsing contract.

- [ ] **Step 8: Commit routed icon Gallery changes**

Stage only Task 5 production/tests and source deletions, excluding `GeneratedFiles`, and commit with `feat: route Material icons through GalleryBase`.

### Task 6: Validate packages and publish one immutable artifact

**Files:**
- Create: `scripts/release/validate_nupkg.py`
- Create: `scripts/release/tests/test_validate_nupkg.py`
- Modify: `.github/workflows/release-material.yml`
- Test: `tests/MaterialGallery.Tests/ReleaseWorkflowTests.cs`

**Interfaces:**
- Produces: `validate_package(path, expected_version, expected_atomui_version) -> PackageReport`, `find_single_package(directory) -> Path`, and a non-zero CLI exit on mismatch.
- Produces: workflow input `SourceRef` and build artifact containing the `.nupkg` plus `SHA256SUMS`.

- [ ] **Step 1: Write failing package-validator tests**

Build synthetic `.nupkg` zip fixtures in memory. Assert the validator accepts ID `AtomUI.Icons.Material`, version `6.2.6`, `net8.0`/`net10.0` assemblies, and direct `AtomUI.Core` dependency `6.2.6`; reject wrong versions, missing frameworks, multiple packages, gallery/generator/temp files, and malformed nuspecs.

- [ ] **Step 2: Write a failing workflow structure test**

Assert checkout uses `inputs.SourceRef`; build/pack occurs only in `build_and_validate`; the artifact contains package plus checksum; `publish` has `needs: build_and_validate`, downloads that artifact, verifies SHA-256, contains `dotnet nuget push`, and contains no `dotnet build` or `dotnet pack`.

- [ ] **Step 3: Run tests and confirm RED**

```bash
python3 -m unittest discover -s scripts/release/tests -p 'test_*.py' -v
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter FullyQualifiedName~ReleaseWorkflowTests
```

Expected: FAIL for the missing validator and monolithic workflow.

- [ ] **Step 4: Implement package validation and split workflow jobs**

The build job restores, builds, tests, packs once, calls `validate_nupkg.py`, writes `SHA256SUMS`, and uploads both. The conditional publish job downloads the artifact, verifies the checksum, pushes that file with `--skip-duplicate`, then queries NuGet to confirm the version. Treat any push/query ambiguity as failure requiring a NuGet lookup before retry.

- [ ] **Step 5: Run validator and workflow tests**

Run the commands from Step 3.

Expected: all Python and filtered .NET tests PASS.

- [ ] **Step 6: Commit release tooling and workflow**

```bash
git add scripts/release/validate_nupkg.py scripts/release/tests/test_validate_nupkg.py .github/workflows/release-material.yml tests/MaterialGallery.Tests/ReleaseWorkflowTests.cs
git commit -m "build: publish validated Material package artifacts"
```

### Task 7: Regenerate, verify, tag, and publish `6.2.6`

**Files:**
- Modify: checked-in generator outputs under `src/AtomUI.Icons.Material/GeneratedIcons/` only if regeneration requires it.
- Modify: checked-in generator outputs under `gallery/MaterialGallery/GeneratedFiles/`.
- Create: temporary package and consumer outputs outside tracked source directories; do not commit them.

**Interfaces:**
- Consumes: Tasks 1–6 and the exact candidate commit SHA.
- Produces: tag `v6.2.6` and NuGet package `AtomUI.Icons.Material` `6.2.6`.

- [ ] **Step 1: Reconcile generated sources**

Build the Material generator for `net10.0`, run it from `.artifacts/bin/Release/net10.0`, review the diff, run it a second time, and require no second-run diff. Build the Gallery to refresh compiler-generated files; review every addition/deletion against AtomUI `6.2.6` generator changes.

- [ ] **Step 2: Run the full local verification suite**

```bash
python3 -m unittest discover -s scripts/release/tests -p 'test_*.py' -v
dotnet restore Material.slnx
dotnet build Material.slnx -c Debug --no-restore
dotnet test Material.slnx -c Debug --no-build
dotnet build Material.slnx -c Release --no-restore
dotnet test Material.slnx -c Release --no-build
dotnet pack src/AtomUI.Icons.Material/AtomUI.Icons.Material.csproj -c Release --no-build -o <clean-output-directory>
python3 scripts/release/validate_nupkg.py <clean-output-directory>/AtomUI.Icons.Material.6.2.6.nupkg --expected-version 6.2.6 --expected-atomui-version 6.2.6
```

Expected: all suites PASS with discovered tests; one valid package is produced.

- [ ] **Step 3: Run a local-feed consumer smoke test**

Create a temporary `net8.0` consumer, add only the clean output directory as a package source, install `AtomUI.Icons.Material` `6.2.6`, reference representative icons from all five themes, and build. Repeat for `net10.0`.

- [ ] **Step 4: Review and commit intentional generated output**

Stage only reviewed generated files, verify `git diff --cached --name-only`, and commit with `build: refresh Material generated sources for 6.2.6`. Skip the commit when regeneration is clean.

- [ ] **Step 5: Establish the immutable candidate**

Require a clean task-owned state, record `git rev-parse HEAD`, confirm NuGet does not contain `6.2.6`, and run `resolve_release_version.py`; it must still report target `6.2.6` and Material remote `6.1.3`.

- [ ] **Step 6: Run the workflow rehearsal**

Dispatch `release-material.yml` with `SourceRef=<candidate-sha>` and `PublishToNuget=false`. Download the artifact, verify `SHA256SUMS`, run `validate_nupkg.py`, and compare metadata to the local candidate.

- [ ] **Step 7: Tag and push the validated candidate**

```bash
git tag -a v6.2.6 <candidate-sha> -m "v6.2.6"
git push origin release/6.0
git push origin v6.2.6
```

Verify `origin/release/6.0` and `v6.2.6^{}` both resolve to `<candidate-sha>` before publication.

- [ ] **Step 8: Publish and verify NuGet**

Dispatch the workflow at the pushed release branch with `SourceRef=<candidate-sha>` and `PublishToNuget=true`. Confirm the publish job consumes its build job artifact, then query the official NuGet V3 index until `6.2.6` is visible. If the outcome is ambiguous, query first and never rebuild or repush blindly.

- [ ] **Step 9: Report release evidence**

Report resolver output, audited commit range, candidate/tag SHA, test counts, visual evidence, package filename and SHA-256, workflow run URL, NuGet version lookup, and any skipped or manual step.
