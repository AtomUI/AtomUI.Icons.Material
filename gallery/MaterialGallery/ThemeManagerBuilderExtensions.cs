using AtomUI.Theme;
using AtomUI.Theme.Language;
using AtomUI.Generated.MaterialGallery;
using MaterialGallery.Controls;

namespace MaterialGallery;

public static class ThemeManagerBuilderExtensions
{
    public static IThemeManagerBuilder UseGalleryControls(this IThemeManagerBuilder themeManagerBuilder)
    {
        foreach (var descriptor in GeneratedThemeSchema.GetControls())
        {
            themeManagerBuilder.AddControlToken(descriptor);
        }

        themeManagerBuilder.AddControlThemesProvider(new GalleryControlThemesProvider());

        var languageProviders = LanguageProviderPool.GetLanguageProviders();
        foreach (var languageProvider in languageProviders)
        {
            themeManagerBuilder.AddLanguageProviders(languageProvider);
        }
        return themeManagerBuilder;
    }
}
