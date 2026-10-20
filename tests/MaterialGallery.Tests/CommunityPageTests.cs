using AtomUI;
using AtomUI.Localization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Headless;
using Avalonia.Threading;
using Avalonia.VisualTree;
using MaterialGallery.Features.Community;
using ReactiveUI;
using DesktopHyperLinkButton = AtomUI.Desktop.Controls.HyperLinkButton;
using DesktopScrollViewer = AtomUI.Desktop.Controls.ScrollViewer;
using SvgControl = Avalonia.Svg.Svg;

namespace MaterialGallery.Tests;

public class CommunityPageTests
{
    [Fact]
    public void Community_links_match_the_AtomUI_reference_page()
    {
        AvaloniaTestApp.EnsureInitialized();
        var page = CreatePage();
        using var host = Show(page);

        AssertLink(page, "CommunityHomePageLink", "https://www.atomui.net");
        AssertLink(page, "CommunityGiteeLink", "https://gitee.com/chinware/atomui");
        AssertLink(page, "CommunityGitHubLink", "https://github.com/chinware/atomui");
    }

    [Fact]
    public void Community_page_matches_the_reference_sections_and_fully_visible_channel_cards()
    {
        AvaloniaTestApp.EnsureInitialized();
        var page = CreatePage();
        using var host = Show(page, 1020, 860);
        using var renderedFrame = host.Window.CaptureRenderedFrame();

        var content = page.FindControl<StackPanel>("CommunityContent").ShouldNotBeNull();
        var scrollViewer = page.FindControl<DesktopScrollViewer>("CommunityScrollViewer").ShouldNotBeNull();
        content.Bounds.Width.ShouldBe(820, 0.5);
        content.TranslatePoint(default, page).ShouldNotBeNull().X.ShouldBe(
            (scrollViewer.Viewport.Width - content.Bounds.Width) / 2, 1);
        content.Children.Select(child => child.Name).ShouldBe([
            "CommunityAboutCard", "CommunityIncubationCard", "CommunityChannels"]);
        page.FindControl<SvgControl>("AtomInnovationLogo")!.Path
            .ShouldBe("/Assets/atom-innovation-logo.svg");
        page.FindControl<SvgControl>("TLAICIncubationLogo")!.Path.ShouldBe("/Assets/TLAIC.svg");

        var text = page.GetVisualDescendants().OfType<TextBlock>().Select(block => block.Text).ToArray();
        text.ShouldContain("About AtomUI");
        text.ShouldContain("To become a world-class provider of productivity software");
        text.ShouldContain("Make digital world builders more efficient");
        text.ShouldContain("AtomUI OSS joins the TLAIC open-source incubation program");

        var channels = page.FindControl<Grid>("CommunityChannels").ShouldNotBeNull();
        channels.Children.OfType<Border>().Count().ShouldBe(4);
        foreach (var name in new[] { "WeChatOfficial", "Telegram", "WeChatGroup", "QQGroup" })
        {
            var card = page.FindControl<Border>($"{name}Card").ShouldNotBeNull();
            var image = page.FindControl<Image>($"{name}QRCode").ShouldNotBeNull();
            image.Source.ShouldNotBeNull();
            image.Bounds.Width.ShouldBe(144, 0.5);
            var origin = image.TranslatePoint(default, card).ShouldNotBeNull();
            origin.X.ShouldBeGreaterThanOrEqualTo(0);
            origin.Y.ShouldBeGreaterThanOrEqualTo(0);
            (origin.X + image.Bounds.Width).ShouldBeLessThanOrEqualTo(card.Bounds.Width);
            (origin.Y + image.Bounds.Height).ShouldBeLessThanOrEqualTo(card.Bounds.Height);
        }

        scrollViewer.Extent.Width.ShouldBeLessThanOrEqualTo(scrollViewer.Viewport.Width + 0.5);
        scrollViewer.Offset = new Vector(0, scrollViewer.Extent.Height - scrollViewer.Viewport.Height);
        Dispatcher.UIThread.RunJobs();
        foreach (var card in channels.Children.OfType<Border>())
        {
            var bottom = card.TranslatePoint(new Point(0, card.Bounds.Height), page).ShouldNotBeNull();
            bottom.Y.ShouldBeLessThanOrEqualTo(page.Bounds.Height);
        }
    }

    [Fact]
    public void Narrow_viewport_preserves_the_reference_width_and_can_scroll_to_all_content()
    {
        AvaloniaTestApp.EnsureInitialized();
        var page = CreatePage();
        using var host = Show(page, 760);

        var scrollViewer = page.GetVisualDescendants().OfType<DesktopScrollViewer>().First();
        scrollViewer.HorizontalScrollBarVisibility.ShouldBe(Avalonia.Controls.Primitives.ScrollBarVisibility.Auto);
        scrollViewer.Viewport.Width.ShouldBeGreaterThan(0);
        scrollViewer.Extent.Width.ShouldBeGreaterThan(scrollViewer.Viewport.Width);
        scrollViewer.Extent.Height.ShouldBeGreaterThan(scrollViewer.Viewport.Height);
        scrollViewer.Offset = new Vector(
            scrollViewer.Extent.Width - scrollViewer.Viewport.Width,
            scrollViewer.Extent.Height - scrollViewer.Viewport.Height);
        Dispatcher.UIThread.RunJobs();
        scrollViewer.Offset.X.ShouldBeGreaterThan(0);
        scrollViewer.Offset.Y.ShouldBeGreaterThan(0);
    }

    private static CommunityPage CreatePage() => new()
    {
        DataContext = new CommunityViewModel(new TestScreen())
    };

    [Fact]
    public void Community_logos_switch_between_light_and_dark_variants()
    {
        AvaloniaTestApp.EnsureInitialized();
        var page = CreatePage();
        using var host = Show(page);

        page.IsDarkThemeMode = true;
        Dispatcher.UIThread.RunJobs();
        page.FindControl<SvgControl>("AtomInnovationLogo")!.Path
            .ShouldBe("/Assets/atom-innovation-logo-white.svg");
        page.FindControl<SvgControl>("TLAICIncubationLogo")!.Path
            .ShouldBe("/Assets/TLAIC-white.svg");

        page.IsDarkThemeMode = false;
        Dispatcher.UIThread.RunJobs();
        page.FindControl<SvgControl>("AtomInnovationLogo")!.Path
            .ShouldBe("/Assets/atom-innovation-logo.svg");
        page.FindControl<SvgControl>("TLAICIncubationLogo")!.Path.ShouldBe("/Assets/TLAIC.svg");
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

    private static WindowContext Show(Control content, double width = 1000, double height = 720)
    {
        Application.Current!.GetLanguageManager()!.ChangeLanguage(LanguageTags.EnUS);
        var window = new Window { Width = width, Height = height, Content = content };
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
