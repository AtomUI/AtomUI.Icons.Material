# Material Gallery UX Refactor Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Rebuild the Material Gallery on GalleryBase with the approved AtomUI-style chrome, a `Categories` navigation group, and polished Overview, Community, and shared icon-catalog pages.

**Architecture:** GalleryBase continues to own the title bar, shell, routing host, responsive sidebar, branding, and footer. `MaterialGalleryModule` supplies immutable product configuration, while three feature modules own Overview, Community, and the shared category-driven icon catalog; generated icon metadata remains behind a per-page repository session.

**Tech Stack:** C# 13, .NET 8/.NET 10, Avalonia 12.1.4, AtomUI 6.2.6, AtomUI.Toolkits.GalleryBase 6.2.6, ReactiveUI, XAML, xUnit v3, Shouldly, Avalonia.Headless.

**Spec:** `docs/superpowers/specs/2026-10-19-material-gallery-ux-architecture-design.md`

## Global Constraints

- Keep `AtomUIVersion=6.2.6`, `MaterialVersion=6.2.6`, and `AvaloniaVersion=12.1.4` unchanged.
- Root navigation order is exactly `Overview`, `Community`, `Categories`; the group is expanded by default and owns the 18 generated category routes.
- The default route is `Overview`.
- Preserve English, Simplified Chinese, Traditional Chinese, and Portuguese (Brazil) localization.
- Preserve 96-item initial and incremental batches, visible overflow scrollbars, search, five themes, copying, motion, and disposal behavior.
- Validate both 1300×900 and 1040×720 without removing height constraints, clipping, nested scrolling, or original trigger conditions.
- Generated Material icon API files are never hand-edited; generator outputs are accepted only after a deterministic second build.
- Preserve unrelated dirty-worktree changes and stage only each task's declared files.

## Review Focus

- At narrow content widths, the five-theme selector wraps without clipping and the icon grid retains usable width; Task 4 adds the layout test.
- A runtime language change updates both sidebar category labels and the active page title without recreating the window; Tasks 1 and 4 add the tests.
- A clipboard completion after route detachment or after a newer request never shows stale success; Task 4 preserves and extends the async tests.
- Rapid category, theme, and search changes dispose previous icons, reset scrolling, and cannot publish stale items; Task 4 adds repository and interaction tests.
- Manual sidebar collapse remains usable across responsive breakpoint changes and exposes an accessible expand/collapse name; Tasks 1 and 5 add behavior and geometry tests.

---

### Task 1: Flat Navigation, Branding, and Collapsible Sidebar

**Files:**
- Modify: `Directory.Packages.props`
- Modify: `gallery/MaterialGallery/MaterialGallery.csproj`
- Create: `gallery/MaterialGallery/GalleryProjectLinks.cs`
- Create: `gallery/MaterialGallery/Features/Overview/OverviewPage.axaml`
- Create: `gallery/MaterialGallery/Features/Overview/OverviewPage.axaml.cs`
- Create: `gallery/MaterialGallery/Features/Overview/OverviewViewModel.cs`
- Create: `gallery/MaterialGallery/Features/Community/CommunityPage.axaml`
- Create: `gallery/MaterialGallery/Features/Community/CommunityPage.axaml.cs`
- Create: `gallery/MaterialGallery/Features/Community/CommunityViewModel.cs`
- Modify: `gallery/MaterialGallery/MaterialGalleryModule.cs`
- Modify: `gallery/MaterialGallery/Workspace/Views/CaseNavigation.axaml.cs`
- Modify: `gallery/MaterialGallery/Workspace/Localization/WorkspaceWindowLang/WorkspaceWindowLangResourceKind.cs`
- Modify: `gallery/MaterialGallery/Workspace/Localization/WorkspaceWindowLang/en-US.xlf`
- Modify: `gallery/MaterialGallery/Workspace/Localization/WorkspaceWindowLang/zh-CN.xlf`
- Modify: `gallery/MaterialGallery/Workspace/Localization/WorkspaceWindowLang/zh-TW.xlf`
- Modify: `gallery/MaterialGallery/Workspace/Localization/WorkspaceWindowLang/pt-BR.xlf`
- Test: `tests/MaterialGallery.Tests/MaterialGalleryModuleTests.cs`
- Test: `tests/MaterialGallery.Tests/GalleryShellMigrationTests.cs`

**Interfaces:**
- Produces: `GalleryProjectLinks.Website = "https://qinware.com"`, `.NuGetPackage = "https://www.nuget.org/packages/AtomUI.Icons.Material"`, `.GitHub = "https://github.com/AtomUI/AtomUI.Icons.Material"`, `.Issues = "https://github.com/AtomUI/AtomUI.Icons.Material/issues"`, and `.AtomUI = "https://www.atomui.net"`.
- Produces: `OverviewViewModel.ID` and `CommunityViewModel.ID` route keys plus constructors accepting `IScreen`.
- Produces: `MaterialGalleryModule.LocalizedCategory(string category) : GalleryLocalizedText<WorkspaceWindowLangResourceKind>` as an internal shared localized-header factory.
- Produces: `CaseNavigation` implementing `IGallerySidebarNavMenuHost` with `SidebarHeaderAction` equal to an AtomUI text button named `NavigationCollapseButton`.
- Consumes: generated `IconInfoRepository.Categories` for category order.

- [ ] **Step 1: Write failing configuration tests**

Add `Configuration_uses_overview_then_community_then_an_expanded_categories_group` and assert the root key sequence, `Categories` children, its default-open state, `Overview` as default, and one registered route for every page key. Add `Branding_exposes_canonical_links_logo_and_compiled_version` and assert the Website, NuGet, and GitHub URLs, supplied AtomUI OSS SVG logo resource, and `GalleryVersionInfo.DisplayVersion`.

- [ ] **Step 2: Write failing sidebar tests**

Replace the current combo-box header assertion with `Sidebar_header_action_toggles_collapse_and_has_accessible_name`. Assert the action is the named AtomUI button, clicking toggles `SidebarNavMenu.IsInlineCollapsed`, and the automation name changes between localized collapse and expand text. Add a language-change test that rebuilds navigation labels without duplicating nodes.

- [ ] **Step 3: Run the focused tests and confirm RED**

Run:

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter "FullyQualifiedName~MaterialGalleryModuleTests|FullyQualifiedName~GalleryShellMigrationTests"
```

Expected: FAIL because Overview/Community routes, canonical links, grouped category ordering, and the collapse button are absent.

- [ ] **Step 4: Add the direct Gallery icon dependency**

Add centrally versioned `AtomUI.Icons.AntDesign` at `$(AtomUIVersion)` and reference it directly from `MaterialGallery.csproj`. Use it only for Gallery navigation, footer, and collapse-action glyphs; it does not enter the packaged Material icon library.

- [ ] **Step 5: Add route contracts and shared project links**

Create minimal routable `OverviewViewModel(IScreen)` and `CommunityViewModel(IScreen)` classes and their typed Gallery reactive views. Define the five absolute project-link constants once in `GalleryProjectLinks`; use the package metadata repository URL as the GitHub canonical value.

- [ ] **Step 6: Configure branding and grouped category navigation**

Split `MaterialGalleryModule.Configure` into focused `ConfigureBranding`, `ConfigureNavigation`, and `ConfigureRoutes` methods. Set `DefaultRoute = OverviewViewModel.ID`; add Overview with `HomeOutlined`, Community with `TeamOutlined`, then add a localized `Categories` group with `AppstoreOutlined` and each generated category as a child through `LocalizedCategory(category)`. Mark the group open by default. Configure footer links with `GlobalOutlined`, `CloudDownloadOutlined`, and `GithubOutlined`. Register all route/view factories without instantiating icon data during configuration.

- [ ] **Step 7: Restore the GalleryBase collapse action**

Port the current AtomUIV6 collapse/expand button behavior into `CaseNavigation`: AntDesign `MenuFoldOutlined` and `MenuUnfoldOutlined` `PathIcon` instances, an accessible localized name, lifecycle-safe subscriptions to `IsInlineCollapsed`, and no icon-theme selector in `SidebarHeaderAction`.

- [ ] **Step 8: Run focused tests**

Run the Step 3 command.

Expected: PASS with exact grouped navigation order and functional collapse behavior.

- [ ] **Step 9: Commit the navigation slice**

Stage only the files declared in Task 1 and commit:

```bash
git commit -m "feat: restore Material Gallery navigation shell"
```

### Task 2: Overview Landing Page

**Files:**
- Modify: `gallery/MaterialGallery/Features/Overview/OverviewPage.axaml`
- Modify: `gallery/MaterialGallery/Features/Overview/OverviewPage.axaml.cs`
- Modify: `gallery/MaterialGallery/Features/Overview/OverviewViewModel.cs`
- Create: `gallery/MaterialGallery/Features/Overview/Localization/OverviewPageLangResourceKind.cs`
- Create: `gallery/MaterialGallery/Features/Overview/Localization/en-US.xlf`
- Create: `gallery/MaterialGallery/Features/Overview/Localization/zh-CN.xlf`
- Create: `gallery/MaterialGallery/Features/Overview/Localization/zh-TW.xlf`
- Create: `gallery/MaterialGallery/Features/Overview/Localization/pt-BR.xlf`
- Modify: `gallery/MaterialGallery/MaterialGallery.csproj`
- Use: `gallery/MaterialGallery/Assets/atomui-material-icons-banner.webp`
- Preserve but exclude from runtime resources: `gallery/MaterialGallery/Assets/atomui-material-icons-banner.png`
- Test: `tests/MaterialGallery.Tests/OverviewPageTests.cs`

**Interfaces:**
- Produces: `OverviewViewModel.PackageName`, `.DotNetCliInstallCommand`, `.PackageReferenceInstallCommand`, and `.PackageManagerInstallCommand` derived from `GalleryVersionInfo.Version`.
- Produces: `OverviewPage.RequestCopyAsync(string command)` returning `Task<bool>` for deterministic clipboard tests.
- Consumes: `GalleryProjectLinks` from Task 1.

- [ ] **Step 1: Write failing view-model tests**

Create `Install_commands_use_the_Material_package_and_compiled_version`. Assert exact commands for `AtomUI.Icons.Material` and `6.2.6`, including XML quoting for PackageReference.

- [ ] **Step 2: Write failing page tests**

Add tests that arrange the page and assert the optimized WebP banner, three installation tabs, three copy actions, `.NET 8` and `.NET 10` tags, and quick links. Add clipboard tests for success, missing clipboard, thrown writes, and detachment before completion.

- [ ] **Step 3: Run Overview tests and confirm RED**

Run:

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter FullyQualifiedName~OverviewPageTests
```

Expected: FAIL because the landing-page content and copy contract do not exist.

- [ ] **Step 4: Implement the Overview view model and copy lifecycle**

Implement the four command properties with `PackageName = "AtomUI.Icons.Material"`. Give `OverviewPage` an injectable clipboard writer for tests, cancel pending work on detachment, and report success only for the latest attached request.

- [ ] **Step 5: Build the approved landing-page layout**

Implement the centered scroll layout from the approved wireframe: banner, install card, three tabs, command/copy rows, and two quick-link cards. Source every visible string from `OverviewPageLangResourceKind` in all four languages.

- [ ] **Step 6: Package only the optimized runtime banner**

Keep the lossless PNG available as the authoring source but exclude it from `AvaloniaResource`; include the 1536×512 WebP as the runtime banner so the Gallery does not ship both copies.

- [ ] **Step 7: Run Overview tests and build**

Run:

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter FullyQualifiedName~OverviewPageTests
dotnet build gallery/MaterialGallery.Desktop/MaterialGallery.Desktop.csproj -c Debug
```

Expected: tests PASS and the desktop Gallery builds.

- [ ] **Step 8: Commit the Overview slice**

Stage only Task 2 files and commit:

```bash
git commit -m "feat: add Material Gallery overview"
```

### Task 3: Project Community Page

**Files:**
- Modify: `gallery/MaterialGallery/Features/Community/CommunityPage.axaml`
- Modify: `gallery/MaterialGallery/Features/Community/CommunityPage.axaml.cs`
- Modify: `gallery/MaterialGallery/Features/Community/CommunityViewModel.cs`
- Create: `gallery/MaterialGallery/Features/Community/Localization/CommunityPageLangResourceKind.cs`
- Create: `gallery/MaterialGallery/Features/Community/Localization/en-US.xlf`
- Create: `gallery/MaterialGallery/Features/Community/Localization/zh-CN.xlf`
- Create: `gallery/MaterialGallery/Features/Community/Localization/zh-TW.xlf`
- Create: `gallery/MaterialGallery/Features/Community/Localization/pt-BR.xlf`
- Test: `tests/MaterialGallery.Tests/CommunityPageTests.cs`

**Interfaces:**
- Produces: `CommunityViewModel` URI properties backed only by `GalleryProjectLinks`.
- Consumes: Task 1 Community route and canonical project links.

- [ ] **Step 1: Write failing community tests**

Create `Community_links_use_the_shared_canonical_project_uris` and assert GitHub, Issues, NuGet, Website, and AtomUI values. Add a headless view test that asserts the hero actions and the three Report an issue, Contribute, and Get the package cards are visible and clickable.

- [ ] **Step 2: Run Community tests and confirm RED**

Run:

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter FullyQualifiedName~CommunityPageTests
```

Expected: FAIL because the skeleton page has no project content.

- [ ] **Step 3: Implement the project-specific Community page**

Build the approved centered scroll layout with a Material Gallery identity card, GitHub and AtomUI actions, and the three project cards. Do not copy AtomUI's QR-code community assets. Bind all URIs through `CommunityViewModel` properties.

- [ ] **Step 4: Add four-language Community localization**

Localize the page title, project description, relationship to AtomUI, action labels, card titles, and descriptions. Keep URI strings and route keys culture-invariant.

- [ ] **Step 5: Run Community and navigation tests**

Run:

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter "FullyQualifiedName~CommunityPageTests|FullyQualifiedName~MaterialGalleryModuleTests"
```

Expected: PASS.

- [ ] **Step 6: Commit the Community slice**

Stage only Task 3 files and commit:

```bash
git commit -m "feat: add Material Gallery community page"
```

### Task 4: Shared Icon Catalog Page and Interaction State

**Files:**
- Create: `gallery/MaterialGallery/Features/IconCatalog/IconCatalogPageViewModel.cs`
- Create: `gallery/MaterialGallery/Features/IconCatalog/IconCatalogPage.axaml`
- Create: `gallery/MaterialGallery/Features/IconCatalog/IconCatalogPage.axaml.cs`
- Create: `gallery/MaterialGallery/Features/IconCatalog/Localization/IconCatalogPageLangResourceKind.cs`
- Create: `gallery/MaterialGallery/Features/IconCatalog/Localization/en-US.xlf`
- Create: `gallery/MaterialGallery/Features/IconCatalog/Localization/zh-CN.xlf`
- Create: `gallery/MaterialGallery/Features/IconCatalog/Localization/zh-TW.xlf`
- Create: `gallery/MaterialGallery/Features/IconCatalog/Localization/pt-BR.xlf`
- Delete after route migration: `gallery/MaterialGallery/Workspace/ViewModels/MaterialIconPageViewModel.cs`
- Delete after route migration: `gallery/MaterialGallery/Workspace/Views/MaterialIconPage.axaml`
- Delete after route migration: `gallery/MaterialGallery/Workspace/Views/MaterialIconPage.axaml.cs`
- Modify: `gallery/MaterialGallery/MaterialGalleryModule.cs`
- Modify: `gallery/MaterialGallery/Models/IconInfoRepository.cs`
- Modify: `gallery/MaterialGallery/Controls/IconGallery/IconGallery.cs`
- Modify: `gallery/MaterialGallery/Controls/IconGallery/Themes/IconGalleryTheme.axaml`
- Modify: `gallery/MaterialGallery/Controls/IconGallery/IconGalleryToken.cs`
- Modify: `tests/MaterialGallery.Tests/IconGalleryInteractionTests.cs`
- Modify: `tests/MaterialGallery.Tests/IconGalleryGeometryTests.cs`
- Modify: `tests/MaterialGallery.Tests/GalleryShellMigrationTests.cs`

**Interfaces:**
- Produces: `IconCatalogPageViewModel(IScreen hostScreen, string category) : ReactiveObject, IRoutableViewModel, IDisposable` with `Category`, observable `CategoryTitle`, `Workspace`, and `IconInfoRepository`.
- Produces: `IconInfoRepository.MatchedIconCount` and `.HasMatches` observable read-only properties.
- Produces: `IconCatalogPage.RequestCopyAsync(string iconName) : Task<bool>` preserving the current latest-request semantics.
- Consumes: `WorkspaceWindowViewModel.IconTheme` as the workspace-wide style preference and `MaterialGalleryModule.LocalizedCategory` for the active title.

- [ ] **Step 1: Extend failing repository tests**

Assert `MatchedIconCount` and `HasMatches` for non-empty and empty searches, all five themes, and category changes. Add a rapid condition-change test that verifies prior materialized icons are disposed and only the latest category/theme/filter result remains.

- [ ] **Step 2: Write failing catalog-header and theme tests**

Arrange `IconCatalogPage` at normal and narrow widths. Assert localized title, result count, exactly five style choices, Filled selected initially, theme selection updating `Workspace.IconTheme`, selection persisting after category navigation, and the selector wrapping without clipping at the minimum content width.

- [ ] **Step 3: Preserve and rename clipboard tests**

Retarget the current rapid-copy, missing clipboard, failed clipboard, and detachment tests to `IconCatalogPage`. Add an assertion that a completion from a removed route cannot show feedback after a newer route becomes active.

- [ ] **Step 4: Add failing empty-state and scroll tests**

Assert an unmatched search displays the localized empty state while keeping search and style controls visible. Preserve scroll reset on category/theme/query changes, visible vertical scrollbar, 96-item batches, bottom-threshold loading, and full-card pointer hits at left/center/right samples.

- [ ] **Step 5: Run focused catalog tests and confirm RED**

Run:

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug --filter "FullyQualifiedName~IconGalleryInteractionTests|FullyQualifiedName~IconGalleryGeometryTests|FullyQualifiedName~GalleryShellMigrationTests"
```

Expected: FAIL because the catalog header, segmented style selector, result state, and renamed route types are absent.

- [ ] **Step 6: Implement the catalog view model and route migration**

Create `IconCatalogPageViewModel` with the exact interface above. Update every category route and view-locator registration to the new shared types, then remove the old MaterialIconPage files only after no references remain.

- [ ] **Step 7: Expose repository result state**

Add observable read-only `MatchedIconCount` and `HasMatches` properties. Update them atomically when conditions change, dispose the previous icon instances before publishing the replacement collection, and retain 96-item paging.

- [ ] **Step 8: Build the approved catalog layout**

Use a root grid with an auto-sized title row and a star-sized `IconGallery` row. The title row contains the observable localized category title/result count and a five-item AtomUI `Segmented`; `IconGallery` retains its search control above its independently scrolling grid. At narrow width, wrap the style selector below the title without changing the Gallery window minimum size. Subscribe the view model to language changes, refresh `CategoryTitle`, and detach that subscription in `Dispose()`.

- [ ] **Step 9: Preserve lifecycle-safe search, scrolling, and copying**

Keep template-part handler detachment, search trimming, scroll reset, incremental-load threshold, icon disposal, and latest-request clipboard cancellation. Add the localized empty-state presentation without overlaying non-empty grid hit targets.

- [ ] **Step 10: Run focused tests**

Run the Step 5 command.

Expected: PASS for state, layout, pointer, scrolling, and clipboard behavior.

- [ ] **Step 11: Commit the icon-catalog slice**

Stage only Task 4 files and commit:

```bash
git commit -m "feat: rebuild Material icon catalog page"
```

### Task 5: Responsive Integration, Generated Outputs, and Visual Acceptance

**Files:**
- Modify as required by evidence: `gallery/MaterialGallery/Workspace/Views/WorkspaceWindow.axaml`
- Modify as required by evidence: `gallery/MaterialGallery/Controls/IconGallery/Themes/IconInfoItemTheme.axaml`
- Modify: `tests/MaterialGallery.Tests/GalleryShellMigrationTests.cs`
- Modify: `tests/MaterialGallery.Tests/IconGalleryGeometryTests.cs`
- Update from generators only: `gallery/MaterialGallery/GeneratedFiles/**`
- Use acceptance evidence outside commits: the scripted visual-acceptance run directory

**Interfaces:**
- Consumes: the complete Gallery from Tasks 1–4.
- Produces: a verified desktop Gallery matching the approved wireframe at 1300×900 and 1040×720.

- [ ] **Step 1: Add complete shell geometry tests**

At both target sizes, assert non-overlapping title bar/sidebar/content/footer bounds, visible sidebar separator, Overview as initial content, expanded and collapsed sidebar widths, accessible collapse action, icon-catalog viewport/extent, and no overlay receiving the sampled icon hit points.

- [ ] **Step 2: Run all Gallery tests before visual tuning**

Run:

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug
```

Expected: PASS before visual-only adjustments; any failing interaction is fixed at its owning layer rather than hidden by layout changes.

- [ ] **Step 3: Build and launch the original desktop reproduction**

Run the Gallery at its 1300×900 initial size and 1040×720 minimum size. Use the scripted visual-acceptance workflow to capture Overview, Community, an icon category, light/dark, expanded/collapsed sidebar, and narrow style-selector wrapping.

- [ ] **Step 4: Perform pointer and scrolling acceptance**

Verify full-card hover/click at left, center, and right grid positions, visible scrollbars, incremental loading, search/no-results recovery, category navigation, inner grid scrolling, route changes, and sidebar responsive collapse. Preserve every original trigger condition during A/B checks.

- [ ] **Step 5: Apply only evidence-backed visual corrections**

Limit changes to spacing, token-driven sizing, wrapping, and hit-test geometry proven by the screenshots or scripted probes. Do not remove constraints, overflow, titles, scrollbars, or nested behavior to make symptoms disappear.

- [ ] **Step 6: Regenerate twice and prove determinism**

Build once to update generator-owned files, review every GeneratedFiles diff, then build a second time and assert no additional generated diff appears. Never hand-edit generated output.

- [ ] **Step 7: Run the complete verification matrix**

Run:

```bash
dotnet test tests/MaterialGallery.Tests/MaterialGallery.Tests.csproj -c Debug
dotnet build Material.slnx -c Debug
dotnet build Material.slnx -c Release
git diff --check
```

Expected: all discovered tests PASS, both configurations build, and the diff check is clean.

- [ ] **Step 8: Audit and remove temporary acceptance artifacts**

Run the scripted visual-acceptance audit/cleanup command for its recorded run directory. Keep only intentional Gallery assets and generator output; remove temporary screenshots, masks, and optimization candidates from the worktree.

- [ ] **Step 9: Commit the verified integration**

Stage only reviewed integration, test, asset, and generator-owned changes and commit:

```bash
git commit -m "test: verify Material Gallery experience"
```

- [ ] **Step 10: Request final whole-branch review**

Review the complete branch against the spec, the AtomUI Gallery reference screenshot, the approved right-side wireframe, and the recorded visual evidence before returning to the release plan.
