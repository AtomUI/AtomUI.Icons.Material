using AtomUI.Theme;
using AtomUI.Theme.Language;
using MaterialGallery.Controls;

namespace MaterialGallery;

public static class ThemeManagerBuilderExtensions
{
    public static IThemeManagerBuilder UseGalleryControls(this IThemeManagerBuilder themeManagerBuilder)
    {
        var controlTokenTypes = ControlTokenTypePool.GetTokenTypes();
        themeManagerBuilder.AddControlThemesProvider(new GalleryControlThemesProvider());
        foreach (var controlToken in controlTokenTypes)
        {
            themeManagerBuilder.AddControlToken(controlToken.TokenType);
        }
        var languageProviders = LanguageProviderPool.GetLanguageProviders();
        foreach (var languageProvider in languageProviders)
        {
            themeManagerBuilder.AddLanguageProviders(languageProvider);
        }
        return themeManagerBuilder;
    }
}
