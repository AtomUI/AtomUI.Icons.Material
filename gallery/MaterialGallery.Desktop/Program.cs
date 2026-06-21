using AtomUI;
using Avalonia;
using ReactiveUI.Avalonia;

namespace MaterialGallery.Desktop;

internal class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        try
        {
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }
        catch (Exception ex)
        {
            LogException(ex);
            throw;
        }
    }

    private static void LogException(Exception ex)
    {
        var homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var logDirectory = Path.Combine(homeDirectory, Path.Combine("MaterialGallery", "AppCrashLogs"));
        Directory.CreateDirectory(logDirectory);
            
        var logFileName = $"CrashLog_{DateTime.Now:yyyyMMdd_HHmmss}.log";
        var logFilePath = Path.Combine(logDirectory, logFileName);
            
        File.WriteAllText(logFilePath, 
            $"CrashTime: {DateTime.Now}\r\n" +
            $"Exception Type: {ex.GetType().Name}\r\n" +
            $"Exception Message: {ex.Message}\r\n" +
            $"Stack Info: \r\n{ex.StackTrace}");
    }

    public static AppBuilder BuildAvaloniaApp()
    {
        var builder = AppBuilder.Configure<GalleryApplication>()
            .UseReactiveUI(_ => { })
            .UsePlatformDetect()
            .WithAtomUIDefaultOptions();
#if DEBUG
        builder = builder.WithDeveloperTools();
#endif
        return builder.LogToTrace();
    }
}
