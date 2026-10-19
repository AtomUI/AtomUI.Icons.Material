using Avalonia.Controls;
using Avalonia.Threading;
using MaterialGallery.Features.Community;
using ReactiveUI;
using DesktopHyperLinkButton = AtomUI.Desktop.Controls.HyperLinkButton;

namespace MaterialGallery.Tests;

public class CommunityPageTests
{
    [Fact]
    public void Community_links_use_the_shared_canonical_project_uris()
    {
        var viewModel = new CommunityViewModel(new TestScreen());

        viewModel.GitHubUri.OriginalString.ShouldBe(GalleryProjectLinks.GitHub);
        viewModel.IssuesUri.OriginalString.ShouldBe(GalleryProjectLinks.Issues);
        viewModel.NuGetUri.OriginalString.ShouldBe(GalleryProjectLinks.NuGetPackage);
        viewModel.WebsiteUri.OriginalString.ShouldBe(GalleryProjectLinks.Website);
        viewModel.AtomUIUri.OriginalString.ShouldBe(GalleryProjectLinks.AtomUI);
    }

    [Fact]
    public void Community_page_exposes_hero_actions_and_three_clickable_project_cards()
    {
        AvaloniaTestApp.EnsureInitialized();
        var page = new CommunityPage
        {
            DataContext = new CommunityViewModel(new TestScreen())
        };
        using var host = Show(page);

        AssertLink(page, "GitHubHeroAction", GalleryProjectLinks.GitHub);
        AssertLink(page, "AtomUIHeroAction", GalleryProjectLinks.AtomUI);
        AssertLink(page, "ReportIssueCard", GalleryProjectLinks.Issues);
        AssertLink(page, "ContributeCard", GalleryProjectLinks.GitHub);
        AssertLink(page, "GetPackageCard", GalleryProjectLinks.NuGetPackage);
    }

    private static void AssertLink(Control root, string name, string expectedUri)
    {
        var link = root.FindControl<DesktopHyperLinkButton>(name);
        link.ShouldNotBeNull();
        link.IsVisible.ShouldBeTrue();
        link.IsEffectivelyEnabled.ShouldBeTrue();
        link.NavigateUri.ShouldNotBeNull();
        link.NavigateUri!.OriginalString.ShouldBe(expectedUri);
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
        public void Dispose()
        {
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    private sealed class TestScreen : IScreen
    {
        public RoutingState Router { get; } = new();
    }
}
