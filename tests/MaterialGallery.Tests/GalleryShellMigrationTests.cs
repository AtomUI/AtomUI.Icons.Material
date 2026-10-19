using AtomUI;
using AtomUI.Controls;
using AtomUI.Localization;
using AtomUI.Toolkits.GalleryBase.Navigation;
using AtomUI.Toolkits.GalleryBase.Shell;
using Avalonia.Automation;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using Avalonia.VisualTree;
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
        using var workspace = new WorkspaceWindowViewModel();

        workspace.ShouldBeAssignableTo<GalleryWorkspaceViewModel>();
        workspace.CaseNavigation.ShouldBeAssignableTo<GalleryNavigationViewModel>();
        workspace.IconTheme.ShouldBe(IconThemeType.Filled);
        workspace.Navigation.ShouldBeSameAs(workspace.CaseNavigation);
    }

    [Fact]
    public void Every_category_navigation_node_can_route_and_disposal_stops_runtime_activity()
    {
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
}
