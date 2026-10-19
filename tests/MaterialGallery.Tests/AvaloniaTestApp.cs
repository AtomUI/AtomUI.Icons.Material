using AtomUI;
using AtomUI.Desktop.Controls;
using AtomUI.Toolkits.GalleryBase;
using Avalonia;
using Avalonia.Headless;

[assembly: AvaloniaTestApplication(typeof(MaterialGallery.Tests.TestAppBuilder))]
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace MaterialGallery.Tests;

internal static class AvaloniaTestApp
{
    private static int _initialized;

    public static void EnsureInitialized()
    {
        if (Interlocked.Exchange(ref _initialized, 1) == 1)
        {
            return;
        }

        TestAppBuilder.BuildAvaloniaApp().SetupWithoutStarting();
    }
}

public static class TestAppBuilder
{
    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure<TestApplication>()
                         .UseHeadless(new AvaloniaHeadlessPlatformOptions())
                         .UseAtomUI(builder =>
                         {
                             builder.UseDesktopControls();
                             builder.UseGalleryBase(global::MaterialGallery.MaterialGalleryModule.Configure);
                             builder.UseGalleryControls();
                         });
    }
}

internal sealed partial class TestApplication : Application;
