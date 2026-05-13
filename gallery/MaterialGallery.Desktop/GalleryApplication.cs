using System.Globalization;
using AtomUI;
using AtomUI.Desktop.Controls;
using AtomUI.Theme;
using Avalonia.Controls.ApplicationLifetimes;

namespace MaterialGallery.Desktop;

public class GalleryApplication : BaseGalleryApplication
{
    public override void Initialize()
    {
        base.Initialize();
        this.UseAtomUI(builder =>
        {
            builder.WithDefaultCultureInfo(CultureInfo.CurrentUICulture);
            builder.WithDefaultTheme(IThemeManager.DEFAULT_THEME_ID);
            builder.UseAlibabaSansFont();
            builder.UseDesktopControls();
            builder.UseGalleryControls();
        });
    }

    public GalleryApplication()
    {
        Name = "Material Icons Gallery";
    }
    
    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                desktop.MainWindow       = CreateWorkspaceWindow();
                desktop.MainWindow.Title = Name;
                break;
        }

        base.OnFrameworkInitializationCompleted();
    }
}
