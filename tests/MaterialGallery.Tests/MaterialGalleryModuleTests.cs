using AtomUI.Toolkits.GalleryBase.Localization;
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
        configuration.Branding.Logo.ShouldBe("avares://MaterialGallery/Assets/gallery-logo.svg");
        configuration.Branding.VersionText.ShouldBe("v6.2.6");
        GalleryVersionInfo.DisplayVersion.ShouldBe("v6.2.6");

        var links = configuration.Branding.Links.ToDictionary(link => link.Key.Value, link => link.Uri);
        links["Website"].ShouldBe(GalleryProjectLinks.Website);
        links["NuGet"].ShouldBe(GalleryProjectLinks.NuGetPackage);
        links["GitHub"].ShouldBe(GalleryProjectLinks.GitHub);
    }

    [Fact]
    public void Configuration_uses_overview_then_community_then_flat_category_routes()
    {
        var repository = new IconInfoRepository();
        var configuration = MaterialGalleryModule.CreateConfiguration();
        var routes = configuration.Routes.Routes;
        var expectedKeys = new[] { OverviewViewModel.ID, CommunityViewModel.ID }
            .Concat(repository.Categories)
            .ToArray();

        configuration.DefaultRoute.Value.ShouldBe(OverviewViewModel.ID);
        configuration.NavigationNodes.Select(node => node.Key.Value).ShouldBe(expectedKeys);
        configuration.NavigationNodes.ShouldAllBe(node => node.Children.Count == 0);
        routes.Count.ShouldBe(expectedKeys.Length);
        foreach (var key in expectedKeys)
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
    public void Configuration_keeps_category_headers_localizable_with_key_fallbacks()
    {
        var repository = new IconInfoRepository();
        var configuration = MaterialGalleryModule.CreateConfiguration();

        var categoryNodes = configuration.NavigationNodes.Skip(2).ToArray();
        categoryNodes.Count().ShouldBe(repository.Categories.Count);
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
