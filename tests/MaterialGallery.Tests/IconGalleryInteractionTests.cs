using AtomUI;
using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using AtomUI.Localization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using Avalonia.VisualTree;
using MaterialGallery.Controls;
using MaterialGallery.Features.IconCatalog;
using MaterialGallery.Models;
using MaterialGallery.Workspace.ViewModels;
using MaterialGallery.Workspace.Views;
using ReactiveUI;
using ScrollViewer = AtomUI.Desktop.Controls.ScrollViewer;

namespace MaterialGallery.Tests;

public class IconGalleryInteractionTests
{
    [Fact]
    public void Repository_supports_five_Material_themes_categories_search_and_96_item_batches()
    {
        var repository = new IconInfoRepository();

        foreach (var theme in MaterialThemes)
        {
            repository.Category = "Action";
            repository.IconTheme = theme;
            repository.Filter = null;
            repository.RefreshIconInfos();

            var initial = repository.ActivatedIconInfos!.ToArray();
            repository.MatchedIconCount.ShouldBeGreaterThanOrEqualTo(initial.Length);
            repository.HasMatches.ShouldBeTrue();
            initial.Length.ShouldBe(96, theme.ToString());
            initial.ShouldAllBe(info => info.Category == "Action" && info.ThemeType == theme);

            repository.LoadMoreIconInfos();
            repository.ActivatedIconInfos!.Count().ShouldBe(192, theme.ToString());
        }

        repository.Category = "Alert";
        repository.Filter = "WARN";
        repository.ActivatedIconInfos.ShouldNotBeNull();
        repository.ActivatedIconInfos.ShouldNotBeEmpty();
        repository.ActivatedIconInfos!.ShouldAllBe(info =>
            info.Category == "Alert" &&
            info.Name.Contains("warn", StringComparison.InvariantCultureIgnoreCase));
        repository.MatchedIconCount.ShouldBeGreaterThanOrEqualTo(repository.ActivatedIconInfos.Count());
        repository.HasMatches.ShouldBeTrue();

        repository.Filter = "__definitely_missing_icon__";
        repository.MatchedIconCount.ShouldBe(0);
        repository.HasMatches.ShouldBeFalse();
        repository.ActivatedIconInfos.ShouldBeEmpty();
    }

    [Fact]
    public void Repository_reset_releases_icons_from_the_previous_result_set()
    {
        var repository = new IconInfoRepository
        {
            Category = "Action",
            IconTheme = IconThemeType.Filled
        };
        repository.RefreshIconInfos();
        var previous = repository.ActivatedIconInfos!.ToArray();
        previous.ShouldNotBeEmpty();
        previous.ShouldAllBe(info => info.Icon != null);

        repository.Category = "Alert";

        var afterCategory = repository.ActivatedIconInfos!.ToArray();
        repository.IconTheme = IconThemeType.Sharp;
        var afterTheme = repository.ActivatedIconInfos!.ToArray();
        repository.Filter = "warn";

        previous.ShouldAllBe(info => info.Icon == null);
        afterCategory.ShouldAllBe(info => info.Icon == null);
        afterTheme.ShouldAllBe(info => info.Icon == null);
        repository.ActivatedIconInfos!.ShouldAllBe(info =>
            info.Category == "Alert" &&
            info.ThemeType == IconThemeType.Sharp &&
            info.Name.Contains("warn", StringComparison.InvariantCultureIgnoreCase));
    }

    [Fact]
    public void Gallery_search_and_result_changes_reset_the_scroll_position()
    {
        AvaloniaTestApp.EnsureInitialized();
        var repository = new IconInfoRepository();
        var gallery = new IconGallery
        {
            Category = "Action",
            IconTheme = IconThemeType.Filled,
            IconInfoRepository = repository
        };
        using var host = Show(gallery, 800, 500);
        var scrollViewer = FindGalleryScrollViewer(gallery);
        scrollViewer.Offset = new Vector(0, 200);

        var search = gallery.GetVisualDescendants().OfType<SearchEdit>().Single();
        search.RaiseEvent(new SearchRequestedEventArgs(
            SearchEdit.SearchRequestedEvent,
            search,
            "  alarm  ",
            SearchTriggerSource.Button));
        Dispatcher.UIThread.RunJobs();

        repository.Filter.ShouldBe("alarm");
        scrollViewer.Offset.Y.ShouldBe(0);
        repository.ActivatedIconInfos!.ShouldAllBe(info =>
            info.Name.Contains("alarm", StringComparison.InvariantCultureIgnoreCase));

        scrollViewer.Offset = new Vector(0, 100);
        gallery.Category = "Alert";
        Dispatcher.UIThread.RunJobs();
        scrollViewer.Offset.Y.ShouldBe(0);

        scrollViewer.Offset = new Vector(0, 100);
        gallery.IconTheme = IconThemeType.Rounded;
        Dispatcher.UIThread.RunJobs();
        scrollViewer.Offset.Y.ShouldBe(0);
    }

    [Fact]
    public async Task Only_the_latest_successful_copy_request_shows_feedback()
    {
        AvaloniaTestApp.EnsureInitialized();
        var writes = new Dictionary<string, TaskCompletionSource>();
        var feedback = new List<string>();
        var page = new IconCatalogPage(
            (text, _) => (writes[text] = new TaskCompletionSource()).Task,
            feedback.Add);
        using var host = Show(page, 800, 500);

        var first = page.RequestCopyAsync("ActionAlarmFilled");
        var second = page.RequestCopyAsync("AlertWarningFilled");
        writes["AlertWarningFilled"].SetResult();
        (await second).ShouldBeTrue();
        writes["ActionAlarmFilled"].SetResult();
        (await first).ShouldBeFalse();

        feedback.ShouldBe(["<AlertWarningFilled /> copied 🎉"]);
    }

    [Fact]
    public async Task Missing_or_failed_clipboard_and_detachment_never_show_success()
    {
        AvaloniaTestApp.EnsureInitialized();

        var missingFeedback = new List<string>();
        var missingPage = new IconCatalogPage(null, missingFeedback.Add);
        using (var missingHost = Show(missingPage, 800, 500))
        {
            (await missingPage.RequestCopyAsync("ActionAlarmFilled")).ShouldBeFalse();
            missingFeedback.ShouldBeEmpty();
        }

        var failedFeedback = new List<string>();
        var failedPage = new IconCatalogPage(
            (_, _) => Task.FromException(new InvalidOperationException("clipboard unavailable")),
            failedFeedback.Add);
        using (var failedHost = Show(failedPage, 800, 500))
        {
            (await failedPage.RequestCopyAsync("ActionAlarmFilled")).ShouldBeFalse();
            failedFeedback.ShouldBeEmpty();
        }

        var deferred = new TaskCompletionSource();
        var detachedFeedback = new List<string>();
        var detachedPage = new IconCatalogPage((_, _) => deferred.Task, detachedFeedback.Add);
        using var detachedHost = Show(detachedPage, 800, 500);
        var pending = detachedPage.RequestCopyAsync("ActionAlarmFilled");
        detachedHost.Window.Content = null;
        Dispatcher.UIThread.RunJobs();
        deferred.SetResult();

        (await pending).ShouldBeFalse();
        detachedFeedback.ShouldBeEmpty();
    }

    [Fact]
    public void Catalog_header_shows_title_count_and_five_persistent_theme_choices()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();
        using var viewModel = new IconCatalogPageViewModel(workspace, "Action");
        var page = new IconCatalogPage { DataContext = viewModel };
        using var host = Show(page, 1020, 620);

        page.FindControl<AtomUI.Desktop.Controls.TextBlock>("CategoryTitle")!.Text.ShouldBe("Action");
        page.FindControl<AtomUI.Desktop.Controls.TextBlock>("ResultCount")!.Text.ShouldNotBeNullOrWhiteSpace();
        var selector = page.FindControl<Segmented>("IconThemeSelector")!;
        selector.Items.Count.ShouldBe(5);
        selector.SelectedIndex.ShouldBe(0);
        var selectorRight = selector.TranslatePoint(new Point(selector.Bounds.Width, 0), page)
                                    .ShouldNotBeNull()
                                    .X;
        selectorRight.ShouldBe(page.Bounds.Width - 24, tolerance: 1);

        selector.SelectedIndex = 2;
        Dispatcher.UIThread.RunJobs();
        workspace.IconTheme.ShouldBe(IconThemeType.Rounded);

        using var nextViewModel = new IconCatalogPageViewModel(workspace, "Alert");
        nextViewModel.SelectedThemeIndex.ShouldBe(2);
    }

    [Fact]
    public void Catalog_header_wraps_at_narrow_width_and_empty_state_preserves_controls()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();
        using var viewModel = new IconCatalogPageViewModel(workspace, "Action");
        var page = new IconCatalogPage { DataContext = viewModel };
        using var host = Show(page, 760, 560);

        var title = page.FindControl<AtomUI.Desktop.Controls.TextBlock>("CategoryTitle")!;
        var selector = page.FindControl<Segmented>("IconThemeSelector")!;
        var selectorTopLeft = selector.TranslatePoint(default, page).ShouldNotBeNull();
        var titleBottomLeft = title.TranslatePoint(new Point(0, title.Bounds.Height), page).ShouldNotBeNull();
        (selectorTopLeft.X + selector.Bounds.Width).ShouldBeLessThanOrEqualTo(page.Bounds.Width);
        selectorTopLeft.Y.ShouldBeGreaterThanOrEqualTo(titleBottomLeft.Y);

        var gallery = page.FindControl<IconGallery>("CatalogGallery")!;
        var search = gallery.GetVisualDescendants().OfType<SearchEdit>().Single();
        search.RaiseEvent(new SearchRequestedEventArgs(
            SearchEdit.SearchRequestedEvent,
            search,
            "__definitely_missing_icon__",
            SearchTriggerSource.Button));
        Dispatcher.UIThread.RunJobs();

        page.GetVisualDescendants()
            .OfType<Border>()
            .Single(control => control.Name == "IconGalleryEmptyState")
            .IsVisible.ShouldBeTrue();
        search.IsVisible.ShouldBeTrue();
        selector.IsVisible.ShouldBeTrue();
    }

    [Fact]
    public async Task Removed_catalog_route_cannot_report_copy_success_after_new_route_is_active()
    {
        AvaloniaTestApp.EnsureInitialized();
        var oldWrite = new TaskCompletionSource();
        var feedback = new List<string>();
        var oldPage = new IconCatalogPage((_, _) => oldWrite.Task, feedback.Add);
        using var host = Show(oldPage, 800, 500);
        var oldRequest = oldPage.RequestCopyAsync("ActionAlarmFilled");

        var newPage = new IconCatalogPage((_, _) => Task.CompletedTask, feedback.Add);
        host.Window.Content = newPage;
        Dispatcher.UIThread.RunJobs();
        (await newPage.RequestCopyAsync("AlertWarningFilled")).ShouldBeTrue();
        oldWrite.SetResult();

        (await oldRequest).ShouldBeFalse();
        feedback.ShouldBe(["<AlertWarningFilled /> copied 🎉"]);
    }

    [Fact]
    public void Catalog_title_tracks_language_until_view_model_is_disposed()
    {
        AvaloniaTestApp.EnsureInitialized();
        var manager = Application.Current!.GetLanguageManager()!;
        manager.ChangeLanguage(LanguageTags.EnUS);
        using var workspace = new WorkspaceWindowViewModel();
        var viewModel = new IconCatalogPageViewModel(workspace, "Action");

        viewModel.CategoryTitle.ShouldBe("Action");
        manager.ChangeLanguage(LanguageTags.ZhCN);
        viewModel.CategoryTitle.ShouldBe("操作");

        viewModel.Dispose();
        manager.ChangeLanguage(LanguageTags.EnUS);
        viewModel.CategoryTitle.ShouldBe("操作");
    }

    [Fact]
    public void Navigating_to_another_category_disposes_the_removed_catalog_session()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();

        workspace.CaseNavigation.NavigateToCommand.Execute("Action").Subscribe();
        Dispatcher.UIThread.RunJobs();
        var first = workspace.Router.NavigationStack[0].ShouldBeOfType<IconCatalogPageViewModel>();
        first.IconInfoRepository.MatchedIconCount.ShouldBeGreaterThan(0);

        workspace.CaseNavigation.NavigateToCommand.Execute("Alert").Subscribe();
        Dispatcher.UIThread.RunJobs();

        workspace.Router.NavigationStack[0].ShouldBeOfType<IconCatalogPageViewModel>()
                 .Category.ShouldBe("Alert");
        first.IconInfoRepository.MatchedIconCount.ShouldBe(0);
        first.IconInfoRepository.HasMatches.ShouldBeFalse();
    }

    private static readonly IconThemeType[] MaterialThemes =
    [
        IconThemeType.Filled,
        IconThemeType.Outlined,
        IconThemeType.Rounded,
        IconThemeType.Sharp,
        IconThemeType.TwoTone
    ];

    private static ScrollViewer FindGalleryScrollViewer(Control gallery)
    {
        return gallery.GetVisualDescendants()
                      .OfType<ScrollViewer>()
                      .Single(viewer =>
                          viewer.Name == "PART_ScrollViewer" &&
                          ReferenceEquals(viewer.TemplatedParent, gallery));
    }

    private static WindowContext Show(Control content, double width, double height)
    {
        var window = new Avalonia.Controls.Window { Width = width, Height = height, Content = content };
        window.Show();
        Dispatcher.UIThread.RunJobs();
        content.ApplyTemplate();
        Dispatcher.UIThread.RunJobs();
        return new WindowContext(window);
    }

    private sealed class WindowContext(Avalonia.Controls.Window window) : IDisposable
    {
        public Avalonia.Controls.Window Window { get; } = window;

        public void Dispose()
        {
            Window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }
}
