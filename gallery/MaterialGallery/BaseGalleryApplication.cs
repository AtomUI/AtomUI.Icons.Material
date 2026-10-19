using Avalonia;
using System.Globalization;
using AtomUI;
using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using AtomUI.Localization;
using AtomUI.Theme;
using AtomUI.Toolkits.GalleryBase;
using MaterialGallery.Localization;

namespace MaterialGallery;

public abstract partial class BaseGalleryApplication : Application
{
    public BaseGalleryApplication()
    {
    }

    protected internal static void ConfigureCore(IAtomUIBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.WithApplicationId("MaterialGallery");
        builder.UseUserThemeDirectory();
        builder.UseLanguages(
            GalleryLanguageDefaults.Resolve(CultureInfo.CurrentUICulture),
            [LanguageTags.EnUS, LanguageTags.ZhCN, LanguageTags.ZhTW, LanguageTags.PtBR]);
        builder.WithInitialTheme(IThemeManager.DEFAULT_THEME_ID);
        builder.UseAlibabaSansFont();
        builder.UseDesktopControls();
        builder.UseGalleryBase(MaterialGalleryModule.Configure);
        builder.UseGalleryControls();
    }
}
