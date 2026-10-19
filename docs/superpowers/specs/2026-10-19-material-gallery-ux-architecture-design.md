# Material Gallery UX Architecture Design

## Summary

The `AtomUI.Icons.Material` Gallery will use `AtomUI.Toolkits.GalleryBase` as its application shell while presenting an information architecture designed for an icon catalog rather than a component library. It preserves the current AtomUI Gallery chrome—Settings, Theme, Language, branding, collapsible sidebar, footer links, and version—while making `Overview`, `Community`, and every Material icon category direct first-level routes.

The default route is `Overview`. The Gallery has no `Components`, `Icons`, or `Material` parent navigation group. All category routes reuse one icon-catalog page implementation and differ only by route category.

## Goals

- Match the current AtomUI Gallery shell and interaction quality without copying component-specific content.
- Keep `Overview` and `Community` as the first two first-level sidebar entries.
- Place all 18 Material icon categories directly below them as first-level entries.
- Provide a polished Overview, project-specific Community page, and reusable icon-catalog page.
- Preserve all five Material icon themes, search, incremental loading, scrolling, copying, localization, and responsive behavior.
- Keep shell concerns in GalleryBase and Material-specific behavior inside focused feature modules.

## Non-goals

- Reintroduce the deleted custom `Navigation` control or duplicate GalleryBase shell behavior.
- Copy AtomUI's `Components` navigation hierarchy.
- Create a separate view or view model class for each icon category.
- Replace the Material icon repository with GalleryBase's AntDesign-specific catalog.
- Add an all-icons aggregate route in this refactor.
- Change the generated public Material icon API.

## User Experience Contract

### Window chrome

The title bar retains the AtomUI Gallery behavior and order:

1. Settings
2. Theme
3. Language

Window options, light/dark mode, compact mode, motion, wave spirit, supported languages, pinning, and platform window controls continue to come from GalleryBase.

### Sidebar

The expanded sidebar contains:

1. Material Gallery brand logo with the navigation collapse button on the right.
2. `Overview`.
3. `Community`.
4. The direct category routes in generated catalog order:
   `Action`, `Alert`, `Av`, `Communication`, `Content`, `Device`, `Editor`, `File`, `Hardware`, `Home`, `Image`, `Maps`, `Navigation`, `Notification`, `Places`, `Search`, `Social`, and `Toggle`.
5. A footer containing Website, NuGet, and GitHub icon links plus `GalleryVersionInfo.DisplayVersion`.

There is no interactive or visual parent node between `Community` and `Action`. Categories are peers of `Overview` and `Community`, not children of `Components` or `Icons`.

The sidebar uses GalleryBase responsive behavior. When collapsed, brand content and the footer hide, category labels collapse according to `NavMenu`, and the collapse/expand action remains available. The header extension point is reserved for the collapse button; the Material icon-theme selector does not occupy it.

### Route-to-content mapping

| Sidebar route | Right-side content |
|---|---|
| `Overview` | `OverviewPage` |
| `Community` | `CommunityPage` |
| Any category | Shared `IconCatalogPage` configured with that category |

`IconCatalogPage(category)` is an implementation pattern, not another navigation level. A route such as `Action` creates the shared page with `Category = "Action"`.

## Right-side Pages

### Overview

The Overview page is a vertically scrollable, centered landing page. Its content width is capped near the AtomUI Gallery baseline so it remains readable at 1300×900 and 1040×720.

Content order:

1. The approved no-version `ATOMUI MATERIAL ICONS` banner.
2. An install card for `AtomUI.Icons.Material` with `.NET 8` and `.NET 10` tags.
3. `.NET CLI`, `PackageReference`, and Package Manager tabs.
4. A copy button for each versioned install command. Commands derive from `GalleryVersionInfo.Version`; no package version is hard-coded in XAML.
5. Quick links to browse the default icon category, NuGet, GitHub, and usage documentation.

The runtime asset is the optimized WebP banner. The lossless PNG may remain an authoring asset only if it is excluded from packaged Gallery resources; the application must not ship both copies unnecessarily.

### Community

The Community page is project-specific rather than a copy of AtomUI's QR-code community page. It contains:

- a short explanation of `AtomUI.Icons.Material` and its relationship to AtomUI;
- GitHub and AtomUI upstream actions;
- cards for reporting issues, contributing, and opening the NuGet package;
- absolute links sourced from one project-link definition rather than repeated literals across XAML and module configuration.

The canonical repository link is `https://github.com/AtomUI/AtomUI.Icons.Material`, consistent with package metadata.

### Icon catalog

Every category route renders the same full-width catalog layout:

1. Header row: localized category title and result count on the left; the five-style selector on the right.
2. Full-width search input below the header.
3. Independently scrollable icon grid filling the remaining height.

The style selector offers `Filled`, `Outlined`, `Rounded`, `Sharp`, and `TwoTone`. At narrower content widths it wraps below the title rather than compressing labels or shrinking the grid to an unusable width.

The vertical scrollbar remains visible when content exceeds the viewport. The fixed header and search controls must not intercept grid pointer input. Clicking an icon copies its component name and displays success feedback only after the current clipboard request succeeds.

## Architecture

### 1. Application composition

`GalleryApplication.Configure` remains the single application composition root. It configures AtomUI, supported languages, theme defaults, desktop controls, GalleryBase, Material Gallery themes, and the main window.

`MaterialGalleryModule` owns the immutable product configuration:

- branding and shared project links;
- footer version;
- ordered navigation nodes;
- default `Overview` route;
- deferred route factories;
- shell and platform options.

The module is split internally into focused configuration methods for branding, navigation, and routes. Configuration creation must not instantiate icon controls or populate icon collections.

### 2. Shell adapter

`WorkspaceWindow` and `WorkspaceWindowViewModel` adapt the Material product to GalleryBase. They do not implement navigation rendering, footer layout, general theme/language state, or responsive sidebar geometry.

`CaseNavigation` owns only:

- the GalleryBase `NavMenu` adapter;
- the collapse/expand button and its accessible presentation;
- language-change rebuilding of localized menu headers;
- lifecycle-safe event subscriptions.

The current icon-theme combo box is removed from `IGallerySidebarNavMenuHost.SidebarHeaderAction`.

### 3. Feature modules

Feature code is organized by page responsibility:

- `Features/Overview`: landing-page view, view model, localization, and install-command copying.
- `Features/Community`: project/community view, view model, localization, and project links.
- `Features/IconCatalog`: shared catalog view, view model, search/theme state, icon grid, and copy feedback.

The existing `MaterialIconPage` may be renamed to `IconCatalogPage` because the latter communicates that it is a shared category browser rather than a page for one icon.

### 4. Catalog domain

Generated icon metadata remains the source of category order and icon factories. The responsibilities are separated as follows:

- Generated catalog data: category membership, icon name, theme, icon type, and factory.
- `IconInfoRepository`: one category query session, filter matching, 96-item initial load, 96-item incremental loads, result count, and disposal of materialized icons.
- `IconCatalogPageViewModel`: route category, shared theme preference, page-local query state, and commands.
- `IconGallery`: rendering, template-part lifecycle, search events, scroll threshold, and item interaction.

`IconInfoRepository` is not an application-wide singleton. Each active routed catalog page owns its query session, making disposal deterministic and preventing filters from leaking between categories.

### 5. Shared state

The selected Material icon theme is workspace-wide and survives category navigation. `WorkspaceWindowViewModel` remains the owner of this single Material-specific preference, or exposes an equivalent focused state object if constructor boundaries require it.

Category is route state. Search text and scroll offset are page state:

- navigating to another category creates a fresh search session;
- changing category, theme, or search resets the grid to the top;
- changing theme preserves the current category and search query;
- returning to a previously removed route does not rely on stale disposed icon instances.

## Data Flow

1. The user selects a category in the first-level `NavMenu`.
2. `GalleryNavigationViewModel` resolves the registered category route.
3. The route factory creates `IconCatalogPageViewModel(category)`.
4. The page view model combines category, workspace icon theme, and page search text.
5. `IconInfoRepository` builds the matching metadata set and materializes the first 96 icons.
6. `IconGallery` loads the next batch when the remaining scroll distance reaches the threshold.
7. A category, theme, or query change disposes the previous materialized icon controls before publishing the next result set.

## Localization

All new visible strings are localized for the four supported Gallery languages:

- English (`en-US`)
- Simplified Chinese (`zh-CN`)
- Traditional Chinese (`zh-TW`)
- Portuguese, Brazil (`pt-BR`)

Navigation labels rebuild when language changes. Route keys, package IDs, URLs, and category identifiers remain culture-invariant.

## Error and Empty States

- Clipboard unavailable, clipboard failure, or page detachment never produces success feedback.
- Only the latest in-flight copy request may display success.
- A search with no matches displays a localized empty state while keeping the search and theme controls available.
- Invalid project links fail GalleryBase configuration validation rather than failing after a click.
- A category present in generated data without a localization entry fails tests and configuration construction.

## Responsive and Interaction Requirements

At both 1300×900 and 1040×720:

- title bar, sidebar, content, separator, and footer bounds remain visible and non-overlapping;
- Overview and Community scroll as whole pages;
- the icon catalog keeps its header/search region visible and scrolls only the grid;
- the grid has non-zero extent and viewport, a visible scrollbar when required, and no overlay intercepting input;
- full icon-card hover and click work at left, center, and right sample points;
- incremental loading works near the lower boundary;
- manual sidebar collapse and GalleryBase responsive collapse both preserve the expected content width;
- compact, light/dark, motion, and language changes preserve layout and interaction behavior.

No height constraint, overflow behavior, visible scrollbar, or nested scrolling trigger may be removed merely to make a test pass.

## Testing and Acceptance

### Configuration tests

- Exact navigation order: `Overview`, `Community`, then the 18 generated categories.
- No `Components`, `Icons`, or `Material` parent navigation node.
- `Overview` is the default route.
- Every route has exactly one deferred view/view-model mapping.
- Branding exposes Website, NuGet, GitHub, and the compiled Material version.

### Page and state tests

- Overview commands use package ID `AtomUI.Icons.Material` and the compiled version.
- All five icon themes update the catalog and persist across category navigation.
- Search is case-insensitive and resets scrolling.
- Initial and incremental batches contain 96 items.
- Replaced result sets release old icon instances.
- Copy success follows the latest successful request only.
- Community and footer links use canonical shared project-link values.

### Geometry and visual acceptance

- Headless geometry checks at 1300×900 and 1040×720.
- Full-row hover/hit tests at left, center, and right positions.
- Scrollbar, viewport, extent, incremental loading, and scroll-boundary checks.
- Scripted screenshots in light/dark and expanded/collapsed sidebar states.
- Manual comparison against the approved right-side wireframe and the referenced AtomUI Gallery screenshot.

Implementation is not complete until the original interaction contract and the approved visual hierarchy both pass.

## Expected Change Boundary

- `gallery/MaterialGallery/MaterialGalleryModule.cs`
- `gallery/MaterialGallery/Workspace/`
- new `gallery/MaterialGallery/Features/Overview/`
- new `gallery/MaterialGallery/Features/Community/`
- new `gallery/MaterialGallery/Features/IconCatalog/`
- `gallery/MaterialGallery/Controls/IconGallery/`
- Gallery localization resources and project assets
- `tests/MaterialGallery.Tests/`

Generated Material icon API files are not hand-edited. Unrelated dirty worktree changes remain untouched.
