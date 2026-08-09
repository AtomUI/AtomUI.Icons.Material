using AtomUI;
using AtomUI.Theme;
using AtomUI.Generated.MaterialGallery;
using MaterialGallery.Controls;

namespace MaterialGallery;

public static class ThemeManagerBuilderExtensions
{
    public static IAtomUIBuilder UseGalleryControls(this IAtomUIBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        GeneratedControlPackageRegistration.Register(
            builder.Theme,
            new GalleryControlThemesProvider());
        GeneratedLanguageModuleRegistration.Register(builder.Localization);
        return builder;
    }
}
