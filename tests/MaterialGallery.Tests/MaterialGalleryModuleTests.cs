using AtomUI.Controls;
using AtomUI.Icons.AntDesign;
using AtomUI.Toolkits.GalleryBase.Localization;
using Avalonia.Controls;
using MaterialGallery.Features.Community;
using MaterialGallery.Features.IconCatalog;
using MaterialGallery.Features.Overview;
using MaterialGallery.Models;
using MaterialGallery.Workspace.ViewModels;
using ReactiveUI;

namespace MaterialGallery.Tests;

public class MaterialGalleryModuleTests
{
    [Fact]
    public void Branding_exposes_canonical_links_logo_and_compiled_version()
    {
        var configuration = MaterialGalleryModule.CreateConfiguration();

        configuration.Branding.AppName.ShouldBe("AtomUI Material Icons");
        configuration.Branding.Logo.ShouldBe("avares://MaterialGallery/Assets/atomui-oss.svg");
        configuration.Branding.VersionText.ShouldBe("v6.2.7");
        GalleryVersionInfo.DisplayVersion.ShouldBe("v6.2.7");

        var links = configuration.Branding.Links.ToDictionary(link => link.Key.Value, link => link.Uri);
        links["Website"].ShouldBe(GalleryProjectLinks.Website);
        links["NuGet"].ShouldBe(GalleryProjectLinks.NuGetPackage);
        links["GitHub"].ShouldBe(GalleryProjectLinks.GitHub);
    }

    [Fact]
    public void Configuration_uses_overview_then_community_then_an_expanded_categories_group()
    {
        AvaloniaTestApp.EnsureInitialized();
        var repository = new IconInfoRepository();
        var configuration = MaterialGalleryModule.CreateConfiguration();
        var routes = configuration.Routes.Routes;
        var expectedRouteKeys = new[] { OverviewViewModel.ID, CommunityViewModel.ID }
            .Concat(repository.Categories).ToArray();

        configuration.DefaultRoute.Value.ShouldBe(OverviewViewModel.ID);
        configuration.NavigationNodes.Select(node => node.Key.Value)
                     .ShouldBe([OverviewViewModel.ID, CommunityViewModel.ID, "Categories"]);
        var categoriesGroup = configuration.NavigationNodes[2];
        categoriesGroup.IsRoute.ShouldBeFalse();
        categoriesGroup.Children.Select(node => node.Key.Value).ShouldBe(repository.Categories);
        categoriesGroup.Children.ShouldAllBe(node => node.IsRoute && node.Children.Count == 0);
        configuration.DefaultOpenKeys.Select(key => key.Value).ShouldBe(["Categories"]);
        routes.Count.ShouldBe(expectedRouteKeys.Length);
        foreach (var key in expectedRouteKeys)
        {
            configuration.Routes.GetRequiredRoute(key).ShouldNotBeNull();
        }

        configuration.Routes.GetRequiredRoute(OverviewViewModel.ID).ViewModelType
                     .ShouldBe(typeof(OverviewViewModel));
        configuration.Routes.GetRequiredRoute(CommunityViewModel.ID).ViewModelType
                     .ShouldBe(typeof(CommunityViewModel));

        using var workspace = new WorkspaceWindowViewModel();
        foreach (var category in repository.Categories)
        {
            var route = configuration.Routes.GetRequiredRoute(category);
            route.ViewModelType.ShouldBe(typeof(IconCatalogPageViewModel));
            route.ViewType.ShouldBe(typeof(IconCatalogPage));

            using var viewModel = route.CreateViewModel(workspace)
                                       .ShouldBeOfType<IconCatalogPageViewModel>();
            viewModel.Category.ShouldBe(category);
            viewModel.UrlPathSegment.ShouldBe(category);
        }
    }

    [Fact]
    public void Every_category_supplies_a_distinct_outlined_icon_and_a_fresh_visual_on_rebuild()
    {
        AvaloniaTestApp.EnsureInitialized();
        var categories = MaterialGalleryModule.CreateConfiguration().NavigationNodes[2].Children;
        var iconTypes = new HashSet<Type>();

        foreach (var category in categories)
        {
            var createIcon = category.Icon.ShouldBeOfType<Func<PathIcon>>(category.Key.Value);
            var icon = createIcon().ShouldBeAssignableTo<AntDesignIcon>();
            icon.IconTheme.ShouldBe(IconThemeType.Outlined, category.Key.Value);
            createIcon().ShouldNotBeSameAs(icon);
            iconTypes.Add(icon.GetType()).ShouldBeTrue(
                $"{category.Key.Value} should have its own recognizable category icon");
        }
    }

    [Fact]
    public void Configuration_keeps_category_headers_localizable_with_key_fallbacks()
    {
        var repository = new IconInfoRepository();
        var configuration = MaterialGalleryModule.CreateConfiguration();

        var categoriesGroup = configuration.NavigationNodes[2];
        var groupHeader = categoriesGroup.Header.ShouldBeAssignableTo<IGalleryLocalizedText>();
        groupHeader.Resolve().ToString().ShouldBe("Categories");

        var categoryNodes = categoriesGroup.Children;
        categoryNodes.Count.ShouldBe(repository.Categories.Count);
        foreach (var pair in categoryNodes.Zip(repository.Categories))
        {
            pair.First.Key.Value.ShouldBe(pair.Second);
            pair.First.IsRoute.ShouldBeTrue();
            var header = pair.First.Header.ShouldBeAssignableTo<IGalleryLocalizedText>();
            header.Resolve().ToString().ShouldBe(pair.Second);
        }
    }

    private sealed class TestScreen : IScreen
    {
        public RoutingState Router { get; } = new();
    }
}
