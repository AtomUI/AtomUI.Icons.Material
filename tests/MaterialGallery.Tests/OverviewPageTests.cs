using Avalonia.Controls;
using Avalonia.Platform;
using Avalonia.Threading;
using MaterialGallery.Features.Overview;
using MaterialGallery.Models;
using ReactiveUI;
using DesktopButton = AtomUI.Desktop.Controls.Button;
using DesktopHyperLinkButton = AtomUI.Desktop.Controls.HyperLinkButton;
using DesktopTag = AtomUI.Desktop.Controls.Tag;
using DesktopTabControl = AtomUI.Desktop.Controls.TabControl;

namespace MaterialGallery.Tests;

public class OverviewPageTests
{
    [Fact]
    public void Install_commands_use_the_Material_package_and_compiled_version()
    {
        var viewModel = new OverviewViewModel(new TestScreen());

        viewModel.PackageName.ShouldBe("AtomUI.Icons.Material");
        viewModel.DotNetCliInstallCommand.ShouldBe(
            $"dotnet add package AtomUI.Icons.Material --version {GalleryVersionInfo.Version}");
        viewModel.PackageReferenceInstallCommand.ShouldBe(
            $"<PackageReference Include=\"AtomUI.Icons.Material\" Version=\"{GalleryVersionInfo.Version}\" />");
        viewModel.PackageManagerInstallCommand.ShouldBe(
            $"Install-Package AtomUI.Icons.Material -Version {GalleryVersionInfo.Version}");
    }

    [Fact]
    public void Landing_page_uses_optimized_banner_install_tabs_copy_actions_tags_and_quick_links()
    {
        AvaloniaTestApp.EnsureInitialized();
        var page = new OverviewPage
        {
            DataContext = new OverviewViewModel(new TestScreen())
        };
        using var host = Show(page);

        page.FindControl<Image>("OverviewBanner")!.Source.ShouldNotBeNull();
        AssetLoader.Exists(new Uri("avares://MaterialGallery/Assets/atomui-material-icons-banner.webp"))
                   .ShouldBeTrue();
        AssetLoader.Exists(new Uri("avares://MaterialGallery/Assets/atomui-material-icons-banner.png"))
                   .ShouldBeFalse();

        page.FindControl<DesktopTabControl>("InstallTabs")!.Items.Count.ShouldBe(3);
        page.FindControl<DesktopButton>("DotNetCliCopyButton").ShouldNotBeNull();
        page.FindControl<DesktopButton>("PackageReferenceCopyButton").ShouldNotBeNull();
        page.FindControl<DesktopButton>("PackageManagerCopyButton").ShouldNotBeNull();
        page.FindControl<DesktopTag>("DotNet8Tag")!.Text.ShouldBe(".NET 8");
        page.FindControl<DesktopTag>("DotNet10Tag")!.Text.ShouldBe(".NET 10");

        page.FindControl<DesktopHyperLinkButton>("BrowseIconsLink")!.NavigateUri.ShouldNotBeNull();
        page.FindControl<DesktopHyperLinkButton>("NuGetLink")!.NavigateUri!.AbsoluteUri
            .ShouldBe(GalleryProjectLinks.NuGetPackage);
        page.FindControl<DesktopHyperLinkButton>("GitHubLink")!.NavigateUri!.AbsoluteUri
            .ShouldBe(GalleryProjectLinks.GitHub);
        page.FindControl<DesktopHyperLinkButton>("UsageLink")!.NavigateUri.ShouldNotBeNull();
    }

    [Fact]
    public async Task Copy_reports_success_only_for_the_latest_attached_request()
    {
        AvaloniaTestApp.EnsureInitialized();
        var writes = new Dictionary<string, TaskCompletionSource>();
        var feedback = new List<string>();
        var page = new OverviewPage(
            (text, _) => (writes[text] = new TaskCompletionSource()).Task,
            feedback.Add);
        using var host = Show(page);

        var first = page.RequestCopyAsync("first command");
        var second = page.RequestCopyAsync("second command");
        writes["second command"].SetResult();
        (await second).ShouldBeTrue();
        writes["first command"].SetResult();
        (await first).ShouldBeFalse();
        feedback.ShouldBe(["Command copied"]);
    }

    [Fact]
    public async Task Missing_or_failed_clipboard_and_detachment_never_report_success()
    {
        AvaloniaTestApp.EnsureInitialized();

        var missingFeedback = new List<string>();
        var missingPage = new OverviewPage(null, missingFeedback.Add);
        using (var missingHost = Show(missingPage))
        {
            (await missingPage.RequestCopyAsync("command")).ShouldBeFalse();
            missingFeedback.ShouldBeEmpty();
        }

        var failedFeedback = new List<string>();
        var failedPage = new OverviewPage(
            (_, _) => Task.FromException(new InvalidOperationException("clipboard unavailable")),
            failedFeedback.Add);
        using (var failedHost = Show(failedPage))
        {
            (await failedPage.RequestCopyAsync("command")).ShouldBeFalse();
            failedFeedback.ShouldBeEmpty();
        }

        var deferred = new TaskCompletionSource();
        var detachedFeedback = new List<string>();
        var detachedPage = new OverviewPage((_, _) => deferred.Task, detachedFeedback.Add);
        using var detachedHost = Show(detachedPage);
        var pending = detachedPage.RequestCopyAsync("command");
        detachedHost.Window.Content = null;
        Dispatcher.UIThread.RunJobs();
        deferred.SetResult();

        (await pending).ShouldBeFalse();
        detachedFeedback.ShouldBeEmpty();
    }

    private static WindowContext Show(Control content)
    {
        var window = new Window { Width = 1000, Height = 720, Content = content };
        window.Show();
        Dispatcher.UIThread.RunJobs();
        content.ApplyTemplate();
        Dispatcher.UIThread.RunJobs();
        return new WindowContext(window);
    }

    private sealed class WindowContext(Window window) : IDisposable
    {
        public Window Window { get; } = window;

        public void Dispose()
        {
            Window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    private sealed class TestScreen : IScreen
    {
        public RoutingState Router { get; } = new();
    }
}
