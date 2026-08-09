using AtomUI;
using AtomUI.Localization;
using Avalonia;
using MaterialGallery.Localization;

namespace MaterialGallery.Models;

internal static class IconCategoryLocalization
{
    public static List<IconCategory> Localize(IEnumerable<string> categoryKeys)
    {
        var localizer = Application.Current?.GetLocalizer();
        return categoryKeys
            .Select(categoryKey => new IconCategory(categoryKey, GetCategoryHeader(localizer, categoryKey)))
            .ToList();
    }

    private static string GetCategoryHeader(ILocalizer? localizer, string categoryKey)
    {
        var resourceKind = ToResourceKind(categoryKey);
        return resourceKind is not null && localizer is not null
            ? localizer.Get(resourceKind.Value)
            : categoryKey;
    }

    private static WorkspaceWindowLangResourceKind? ToResourceKind(string categoryKey)
    {
        return categoryKey switch
        {
            "Action"        => WorkspaceWindowLangResourceKind.IconCategoryAction,
            "Alert"         => WorkspaceWindowLangResourceKind.IconCategoryAlert,
            "Av"            => WorkspaceWindowLangResourceKind.IconCategoryAv,
            "Communication" => WorkspaceWindowLangResourceKind.IconCategoryCommunication,
            "Content"       => WorkspaceWindowLangResourceKind.IconCategoryContent,
            "Device"        => WorkspaceWindowLangResourceKind.IconCategoryDevice,
            "Editor"        => WorkspaceWindowLangResourceKind.IconCategoryEditor,
            "File"          => WorkspaceWindowLangResourceKind.IconCategoryFile,
            "Hardware"      => WorkspaceWindowLangResourceKind.IconCategoryHardware,
            "Home"          => WorkspaceWindowLangResourceKind.IconCategoryHome,
            "Image"         => WorkspaceWindowLangResourceKind.IconCategoryImage,
            "Maps"          => WorkspaceWindowLangResourceKind.IconCategoryMaps,
            "Navigation"    => WorkspaceWindowLangResourceKind.IconCategoryNavigation,
            "Notification"  => WorkspaceWindowLangResourceKind.IconCategoryNotification,
            "Places"        => WorkspaceWindowLangResourceKind.IconCategoryPlaces,
            "Search"        => WorkspaceWindowLangResourceKind.IconCategorySearch,
            "Social"        => WorkspaceWindowLangResourceKind.IconCategorySocial,
            "Toggle"        => WorkspaceWindowLangResourceKind.IconCategoryToggle,
            _               => null
        };
    }
}
