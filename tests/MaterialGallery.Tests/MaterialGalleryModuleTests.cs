using AtomUI.Toolkits.GalleryBase.Localization;
using MaterialGallery.Models;
using MaterialGallery.Workspace.ViewModels;
using MaterialGallery.Workspace.Views;
using ReactiveUI;

namespace MaterialGallery.Tests;

public class MaterialGalleryModuleTests
{
    [Fact]
    public void Configuration_exposes_Material_branding_and_compiled_version()
    {
        var configuration = MaterialGalleryModule.CreateConfiguration();

        configuration.Branding.AppName.ShouldBe("AtomUI Material Icons");
        configuration.Branding.VersionText.ShouldBe("v6.2.6");
        GalleryVersionInfo.DisplayVersion.ShouldBe("v6.2.6");
    }

    [Fact]
    public void Configuration_maps_every_generated_category_to_a_deferred_Material_page()
    {
        var repository = new IconInfoRepository();
        var configuration = MaterialGalleryModule.CreateConfiguration();
        var routes = configuration.Routes.Routes;

        configuration.DefaultRoute.Value.ShouldBe("Action");
        routes.Count.ShouldBe(repository.Categories.Count);

        foreach (var category in repository.Categories)
        {
            var route = configuration.Routes.GetRequiredRoute(category);
            route.ViewModelType.ShouldBe(typeof(MaterialIconPageViewModel));
            route.ViewType.ShouldBe(typeof(MaterialIconPage));

            var viewModel = route.CreateViewModel(new TestScreen())
                                 .ShouldBeOfType<MaterialIconPageViewModel>();
            viewModel.Category.ShouldBe(category);
            viewModel.UrlPathSegment.ShouldBe(category);
        }
    }

    [Fact]
    public void Configuration_keeps_category_headers_localizable_with_key_fallbacks()
    {
        var repository = new IconInfoRepository();
        var configuration = MaterialGalleryModule.CreateConfiguration();

        configuration.NavigationNodes.Count.ShouldBe(repository.Categories.Count);
        foreach (var pair in configuration.NavigationNodes.Zip(repository.Categories))
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
