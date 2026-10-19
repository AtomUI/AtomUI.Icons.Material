using AtomUI;
using AtomUI.Controls;
using AtomUI.Localization;
using AtomUI.Toolkits.GalleryBase.Navigation;
using AtomUI.Toolkits.GalleryBase.Shell;
using MaterialGallery.Models;
using MaterialGallery.Workspace.ViewModels;
using MaterialGallery.Workspace.Views;
using ReactiveUI;
using ComboBox = AtomUI.Desktop.Controls.ComboBox;

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
    public void Sidebar_hosts_a_NavMenu_and_exactly_five_icon_theme_choices()
    {
        AvaloniaTestApp.EnsureInitialized();
        var view = new CaseNavigation();
        var host = view.ShouldBeAssignableTo<IGallerySidebarNavMenuHost>();

        host.SidebarNavMenu.ShouldNotBeNull();
        var selector = host.SidebarHeaderAction.ShouldBeOfType<ComboBox>();
        selector.Items.Count.ShouldBe(5);
    }
}
