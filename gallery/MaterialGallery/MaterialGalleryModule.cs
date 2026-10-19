using AtomUI.Controls;
using AtomUI.Toolkits.GalleryBase.Configuration;
using AtomUI.Toolkits.GalleryBase.Localization;
using AtomUI.Toolkits.GalleryBase.Routing;
using MaterialGallery.Localization;
using MaterialGallery.Models;
using MaterialGallery.Workspace.ViewModels;
using MaterialGallery.Workspace.Views;
using ReactiveUI;

namespace MaterialGallery;

public static class MaterialGalleryModule
{
    private static readonly Lazy<IReadOnlyList<GalleryRouteDescriptor>> RouteDescriptors =
        new(CreateRouteDescriptors);

    public static GalleryBaseConfiguration CreateConfiguration()
    {
        var options = new GalleryBaseOptions();
        Configure(options);
        return options.BuildConfiguration();
    }

    public static GalleryBaseConfiguration GetConfiguration()
    {
        return GalleryBaseConfigurationProvider.Current ?? CreateConfiguration();
    }

    public static void Configure(GalleryBaseOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);

        options.Branding.AppName     = "AtomUI Material Icons";
        options.Branding.Logo        = "avares://MaterialGallery/Assets/gallery-logo.png";
        options.Branding.VersionText = GalleryVersionInfo.DisplayVersion;
        options.Branding.Links.Add(new GalleryLink(
            "GitHub",
            "https://github.com/chinware/AtomUI.Icons.Material"));

        var categories = new IconInfoRepository().Categories;
        options.Navigation.DefaultRoute = "Action";
        foreach (var category in categories)
        {
            options.Navigation.AddPage(category, LocalizedCategory(category));
        }

        foreach (var route in RouteDescriptors.Value)
        {
            options.Routes.Map(route);
        }
    }

    public static void RegisterViews(DefaultViewLocator locator)
    {
        ArgumentNullException.ThrowIfNull(locator);
        locator.Map<MaterialIconPageViewModel, MaterialIconPage>(static () => new MaterialIconPage());
    }

    private static IReadOnlyList<GalleryRouteDescriptor> CreateRouteDescriptors()
    {
        var routes = new GalleryRouteRegistry();
        foreach (var category in new IconInfoRepository().Categories)
        {
            var capturedCategory = category;
            routes.Map<MaterialIconPageViewModel, MaterialIconPage>(
                category,
                screen => new MaterialIconPageViewModel(screen, capturedCategory),
                static () => new MaterialIconPage());
        }
        return routes.Routes;
    }

    private static object LocalizedCategory(string category)
    {
        if (!Enum.TryParse<WorkspaceWindowLangResourceKind>(
                $"IconCategory{category}",
                out var resourceKind))
        {
            throw new InvalidOperationException($"No localized header exists for icon category '{category}'.");
        }

        return new GalleryLocalizedText<WorkspaceWindowLangResourceKind>(resourceKind, category);
    }
}
