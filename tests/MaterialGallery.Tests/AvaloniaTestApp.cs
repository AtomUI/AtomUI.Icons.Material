using AtomUI;
using AtomUI.Desktop.Controls;
using AtomUI.Toolkits.GalleryBase;
using Avalonia;
using Avalonia.Headless;
using ReactiveUI.Avalonia;

[assembly: AvaloniaTestApplication(typeof(MaterialGallery.Tests.TestAppBuilder))]
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace MaterialGallery.Tests;

internal static class AvaloniaTestApp
{
    private static int _initialized;

    public static void EnsureInitialized()
    {
        if (Interlocked.CompareExchange(ref _initialized, 1, 0) != 0)
        {
            return;
        }

        try
        {
            TestAppBuilder.BuildAvaloniaApp().SetupWithoutStarting();
        }
        catch
        {
            Volatile.Write(ref _initialized, 0);
            throw;
        }
    }
}

public static class TestAppBuilder
{
    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure<TestApplication>()
                         .UseHeadless(new AvaloniaHeadlessPlatformOptions())
                         .UseReactiveUI(build =>
                             build.ConfigureViewLocator(locator =>
                                 global::MaterialGallery.MaterialGalleryModule.RegisterViews(locator)))
                         .UseAtomUI(BaseGalleryApplication.ConfigureCore);
    }
}

internal sealed partial class TestApplication : Application;
