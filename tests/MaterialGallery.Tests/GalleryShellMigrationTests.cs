using AtomUI;
using AtomUI.Controls;
using AtomUI.Localization;
using AtomUI.Toolkits.GalleryBase.Navigation;
using AtomUI.Toolkits.GalleryBase.Shell;
using Avalonia.Automation;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Headless;
using Avalonia.Input;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Threading;
using Avalonia.VisualTree;
using MaterialGallery.Features.Overview;
using MaterialGallery.Features.IconCatalog;
using MaterialGallery.Models;
using MaterialGallery.Workspace.ViewModels;
using MaterialGallery.Workspace.Views;
using ReactiveUI;
using DesktopButton = AtomUI.Desktop.Controls.Button;
using NavMenuNode = AtomUI.Desktop.Controls.NavMenuNode;

namespace MaterialGallery.Tests;

public class GalleryShellMigrationTests
{
    [Fact]
    public void Application_configuration_registers_GalleryBase_and_all_supported_languages()
    {
        AvaloniaTestApp.EnsureInitialized();

        MaterialGalleryModule.GetConfiguration().Branding.AppName.ShouldBe("AtomUI Material Icons");

        var supportedLanguages = Avalonia.Application.Current!
                                         .GetLanguageManager()!
                                         .SupportedLanguages
                                         .Select(language => language.Tag.Value)
                                         .ToArray();
        supportedLanguages.ShouldBe([
            LanguageTags.EnUS.Value,
            LanguageTags.ZhCN.Value,
            LanguageTags.ZhTW.Value,
            LanguageTags.PtBR.Value
        ], ignoreOrder: true);
    }

    [Fact]
    public void Workspace_delegates_shared_state_to_GalleryBase_and_defaults_to_filled_icons()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();

        workspace.ShouldBeAssignableTo<GalleryWorkspaceViewModel>();
        workspace.CaseNavigation.ShouldBeAssignableTo<GalleryNavigationViewModel>();
        workspace.IconTheme.ShouldBe(IconThemeType.Filled);
        workspace.Navigation.ShouldBeSameAs(workspace.CaseNavigation);
    }

    [Fact]
    public void Every_category_navigation_node_can_route_and_disposal_stops_runtime_activity()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();
        var categories = new IconInfoRepository().Categories;

        foreach (var category in categories)
        {
            workspace.CaseNavigation.CanNavigateTo(category).ShouldBeTrue(category);
        }

        workspace.CaseNavigation.NavigateToCommand.Execute("Action").Subscribe();
        workspace.Router.NavigationStack.Count.ShouldBe(1);

        workspace.Dispose();
        workspace.CaseNavigation.NavigateToCommand.Execute("Alert").Subscribe();
        workspace.Router.NavigationStack.Count.ShouldBe(1);
    }

    [Fact]
    public void Sidebar_header_action_toggles_collapse_and_has_accessible_name()
    {
        AvaloniaTestApp.EnsureInitialized();
        var view = new CaseNavigation();
        var host = view.ShouldBeAssignableTo<IGallerySidebarNavMenuHost>();
        var manager = Avalonia.Application.Current!.GetLanguageManager()!;
        var window = new Window { Content = view };

        try
        {
            manager.ChangeLanguage(LanguageTags.EnUS);
            window.Show();
            Dispatcher.UIThread.RunJobs();

            var button = host.SidebarHeaderAction.ShouldBeOfType<DesktopButton>();
            button.Name.ShouldBe("NavigationCollapseButton");
            host.SidebarNavMenu.IsInlineCollapsed.ShouldBeFalse();
            AutomationProperties.GetName(button).ShouldBe("Collapse navigation");

            button.RaiseEvent(new RoutedEventArgs(DesktopButton.ClickEvent));

            host.SidebarNavMenu.IsInlineCollapsed.ShouldBeTrue();
            AutomationProperties.GetName(button).ShouldBe("Expand navigation");
        }
        finally
        {
            manager.ChangeLanguage(LanguageTags.EnUS);
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    [Fact]
    public void Language_change_rebuilds_navigation_labels_without_duplicating_nodes()
    {
        AvaloniaTestApp.EnsureInitialized();
        var view = new CaseNavigation();
        var host = view.ShouldBeAssignableTo<IGallerySidebarNavMenuHost>();
        var manager = Avalonia.Application.Current!.GetLanguageManager()!;
        var expectedCount = MaterialGalleryModule.CreateConfiguration().NavigationNodes.Count;
        var window = new Window { Content = view };

        try
        {
            manager.ChangeLanguage(LanguageTags.EnUS);
            window.Show();
            Dispatcher.UIThread.RunJobs();
            host.SidebarNavMenu.Items.Count.ShouldBe(expectedCount);

            manager.ChangeLanguage(LanguageTags.ZhCN);
            Dispatcher.UIThread.RunJobs();

            host.SidebarNavMenu.Items.Count.ShouldBe(expectedCount);
            host.SidebarNavMenu.Items
                .OfType<NavMenuNode>()
                .Select(item => item.ItemKey!.Value.Value)
                .Distinct()
                .Count()
                .ShouldBe(expectedCount);
        }
        finally
        {
            manager.ChangeLanguage(LanguageTags.EnUS);
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    [Fact]
    public void Workspace_window_loads_its_packaged_icon_and_GalleryBase_shell()
    {
        AvaloniaTestApp.EnsureInitialized();
        var window = new WorkspaceWindow();

        try
        {
            window.Show();
            Dispatcher.UIThread.RunJobs();
            window.Icon.ShouldNotBeNull();
            window.GetVisualDescendants().OfType<GalleryShellView>().Single().ShouldNotBeNull();
        }
        finally
        {
            window.Close();
        }
    }

    [Theory]
    [InlineData(1300, 900)]
    [InlineData(1040, 720)]
    public void Workspace_window_preserves_the_complete_shell_geometry_and_collapse_contract(
        double width,
        double height)
    {
        AvaloniaTestApp.EnsureInitialized();
        var window = new TitleBarInspectableWorkspaceWindow
        {
            Width  = width,
            Height = height
        };

        try
        {
            window.Show();
            Dispatcher.UIThread.RunJobs();
            using var expandedFrame = window.CaptureRenderedFrame();

            var shell = window.GetVisualDescendants().OfType<GalleryShellView>().Single();
            var titleBar = window.ConfiguredTitleBar
                                 .ShouldBeOfType<AtomUI.Toolkits.GalleryBase.Controls.GalleryWindowTitleBar>();
            titleBar.Menu.ShouldNotBeNull();
            var sidebar = FindNamed<Border>(shell, "WorkspaceSidebar");
            var separator = FindNamed<Border>(shell, "WorkspaceNavigationSeparator");
            var footer = FindNamed<Border>(shell, "WorkspaceSidebarFooter");
            var rootLayout = FindNamed<Grid>(shell, "WorkspaceRootLayout");
            var collapseButton = window.GetVisualDescendants()
                                       .OfType<DesktopButton>()
                                       .Single(button => button.Name == "NavigationCollapseButton");

            var rootRect = BoundsInWindow(rootLayout, window);
            var sidebarRect = BoundsInWindow(sidebar, window);
            var contentRect = BoundsInWindow(shell.ContentHost, window);
            var separatorRect = BoundsInWindow(separator, window);
            var footerRect = BoundsInWindow(footer, window);

            if (titleBar.IsAttachedToVisualTree())
            {
                var titleBarRect = BoundsInWindow(titleBar, window);
                titleBarRect.Height.ShouldBeGreaterThan(0);
                titleBarRect.Bottom.ShouldBeLessThanOrEqualTo(rootRect.Top + 1);
            }
            else
            {
                // Windows CSD uses drawn decorations outside the headless client visual tree.
                // The configured Gallery title bar/menu and all client geometry are still checked.
                OperatingSystem.IsWindows().ShouldBeTrue();
            }
            sidebarRect.Right.ShouldBeLessThanOrEqualTo(contentRect.Left + 1);
            separatorRect.Width.ShouldBe(1, 0.01);
            separatorRect.Left.ShouldBe(contentRect.Left, 1);
            separatorRect.Top.ShouldBe(rootRect.Top, 1);
            separatorRect.Bottom.ShouldBe(rootRect.Bottom, 1);
            footerRect.Left.ShouldBeGreaterThanOrEqualTo(sidebarRect.Left);
            footerRect.Right.ShouldBeLessThanOrEqualTo(sidebarRect.Right);
            footerRect.Bottom.ShouldBeLessThanOrEqualTo(sidebarRect.Bottom + 1);
            footerRect.Top.ShouldBeGreaterThan(sidebarRect.Top);
            RectanglesOverlap(footerRect, contentRect).ShouldBeFalse();
            window.ViewModel!.Router.GetCurrentViewModel().ShouldBeOfType<OverviewViewModel>();

            var navMenu = ((IGallerySidebarNavMenuHost)window.GetVisualDescendants()
                .OfType<CaseNavigation>()
                .Single()).SidebarNavMenu;
            var initialCollapsed = navMenu.IsInlineCollapsed;
            var initialSidebarWidth = sidebar.Bounds.Width;
            var initialContentWidth = shell.ContentHost.Bounds.Width;
            AutomationProperties.GetName(collapseButton).ShouldBe(
                initialCollapsed ? "Expand navigation" : "Collapse navigation");

            collapseButton.RaiseEvent(new RoutedEventArgs(DesktopButton.ClickEvent));
            var targetSidebarWidth = initialCollapsed
                ? MaterialGalleryModule.GetConfiguration().Shell.SidebarWidth
                : navMenu.InlineCollapsedWidth;
            SpinWait.SpinUntil(() =>
            {
                Dispatcher.UIThread.RunJobs();
                window.UpdateLayout();
                return Math.Abs(sidebar.Bounds.Width - targetSidebarWidth) <= 0.5;
            }, TimeSpan.FromSeconds(3)).ShouldBeTrue(
                $"sidebar collapse animation should reach its target width of {targetSidebarWidth}");
            using var toggledFrame = window.CaptureRenderedFrame();

            navMenu.IsInlineCollapsed.ShouldBe(!initialCollapsed);
            AutomationProperties.GetName(collapseButton).ShouldBe(
                initialCollapsed ? "Collapse navigation" : "Expand navigation");
            if (initialCollapsed)
            {
                sidebar.Bounds.Width.ShouldBeGreaterThan(initialSidebarWidth);
                shell.ContentHost.Bounds.Width.ShouldBeLessThan(initialContentWidth);
            }
            else
            {
                sidebar.Bounds.Width.ShouldBeLessThan(initialSidebarWidth);
                shell.ContentHost.Bounds.Width.ShouldBeGreaterThan(initialContentWidth);
            }
        }
        finally
        {
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    [Theory]
    [InlineData(1300, 900)]
    [InlineData(1040, 720)]
    public void Sidebar_rows_receive_full_width_pointer_input_and_real_headless_wheel_events(
        double width, double height)
    {
        AvaloniaTestApp.EnsureInitialized();
        Avalonia.Application.Current!.GetLanguageManager()!.ChangeLanguage(LanguageTags.EnUS);
        var window = new WorkspaceWindow { Width = width, Height = height };
        try
        {
            window.Show();
            Dispatcher.UIThread.RunJobs();
            using var frame = window.CaptureRenderedFrame();
            var navigation = window.GetVisualDescendants().OfType<CaseNavigation>().Single();
            var menu = ((IGallerySidebarNavMenuHost)navigation).SidebarNavMenu;
            menu.IsInlineCollapsed.ShouldBeFalse();
            var rows = menu.GetVisualDescendants().OfType<HeaderedSelectingItemsControl>().ToArray();
            var row = rows.FirstOrDefault(control => (control.Header as NavMenuNode)?.ItemKey?.Value == "Action")
                          .ShouldNotBeNull(string.Join(", ", rows.Select(control => $"{control.GetType().Name}:{control.Header}")));
            var header = row.GetVisualDescendants().OfType<Control>()
                            .Single(control => control.Name == "PART_Header" && ReferenceEquals(control.TemplatedParent, row));
            var root = window.Content.ShouldBeOfType<Grid>();
            var overlay = new Border { Background = Avalonia.Media.Brushes.Transparent };
            var center = header.TranslatePoint(new Point(header.Bounds.Width / 2, header.Bounds.Height / 2), window)
                            .ShouldNotBeNull();

            // A blocking overlay is a negative control: positive bounds alone must not pass.
            root.Children.Add(overlay);
            window.UpdateLayout();
            using var blockedFrame = window.CaptureRenderedFrame();
            (window.InputHitTest(center) as Visual).ShouldBeSameAs(overlay);
            root.Children.Remove(overlay);
            window.UpdateLayout();
            using var unblockedFrame = window.CaptureRenderedFrame();

            foreach (var x in new[] { 2d, header.Bounds.Width / 2, header.Bounds.Width - 2 })
            {
                window.ViewModel!.CaseNavigation.NavigateToCommand.Execute(OverviewViewModel.ID).Subscribe();
                Dispatcher.UIThread.RunJobs();
                var point = header.TranslatePoint(new Point(x, header.Bounds.Height / 2), window).ShouldNotBeNull();
                var hit = (window.InputHitTest(point) as Visual).ShouldNotBeNull();
                (ReferenceEquals(hit, row) || hit.GetVisualAncestors().Contains(row)).ShouldBeTrue(
                    $"Sidebar Action row should own its full-width input point {point}");
                window.MouseMove(point);
                row.IsPointerOver.ShouldBeTrue();
                window.MouseDown(point, MouseButton.Left);
                window.MouseUp(point, MouseButton.Left);
                Dispatcher.UIThread.RunJobs();
                window.ViewModel.Router.GetCurrentViewModel().ShouldBeOfType<IconCatalogPageViewModel>()
                      .Category.ShouldBe("Action", $"click at {point}, header={header.Bounds}, row={row.Bounds}");
            }

            var scroll = menu.GetVisualDescendants().OfType<Avalonia.Controls.ScrollViewer>()
                             .First(viewer => viewer.Viewport.Height > 0 && viewer.Extent.Height > viewer.Viewport.Height);
            var initialOffset = scroll.Offset.Y;
            window.MouseWheel(center, new Vector(0, -5));
            SpinWait.SpinUntil(() =>
            {
                Dispatcher.UIThread.RunJobs();
                window.UpdateLayout();
                return scroll.Offset.Y > initialOffset;
            }, TimeSpan.FromSeconds(3)).ShouldBeTrue("a wheel event over the sidebar row should scroll the category list");
        }
        finally
        {
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    private sealed class TitleBarInspectableWorkspaceWindow : WorkspaceWindow
    {
        public AtomUI.Desktop.Controls.WindowTitleBar? ConfiguredTitleBar { get; private set; }

        protected override void NotifyConfigureTitleBar(AtomUI.Desktop.Controls.WindowTitleBar titleBar)
        {
            base.NotifyConfigureTitleBar(titleBar);
            ConfiguredTitleBar = titleBar;
        }
    }

    private static T FindNamed<T>(Visual root, string name)
        where T : Control
    {
        return root.GetVisualDescendants().OfType<T>().Single(control => control.Name == name);
    }

    private static Rect BoundsInWindow(Visual visual, Visual window)
    {
        var origin = visual.TranslatePoint(default, window).ShouldNotBeNull();
        return new Rect(origin, visual.Bounds.Size);
    }

    private static bool RectanglesOverlap(Rect first, Rect second)
    {
        return first.Left < second.Right && first.Right > second.Left &&
               first.Top < second.Bottom && first.Bottom > second.Top;
    }
}
