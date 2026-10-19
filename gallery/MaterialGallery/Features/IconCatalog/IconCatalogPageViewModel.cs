using System.Reactive.Disposables;
using System.Reactive.Disposables.Fluent;
using System.Reactive.Linq;
using AtomUI;
using AtomUI.Controls;
using AtomUI.Localization;
using AtomUI.Toolkits.GalleryBase.Localization;
using Avalonia;
using MaterialGallery.Localization;
using MaterialGallery.Models;
using MaterialGallery.Workspace.ViewModels;
using ReactiveUI;

namespace MaterialGallery.Features.IconCatalog;

public sealed class IconCatalogPageViewModel : ReactiveObject, IRoutableViewModel, IDisposable
{
    private static readonly IconThemeType[] Themes =
    [
        IconThemeType.Filled,
        IconThemeType.Outlined,
        IconThemeType.Rounded,
        IconThemeType.Sharp,
        IconThemeType.TwoTone
    ];

    private readonly CompositeDisposable _subscriptions = new();
    private readonly ILanguageManager? _languageManager;
    private readonly EventHandler<LanguageChangedEventArgs>? _languageChangedHandler;
    private string _categoryTitle = string.Empty;
    private string _resultSummary = string.Empty;
    private int _selectedThemeIndex;
    private bool _isDisposed;

    public IScreen HostScreen { get; }

    public string Category { get; }

    public string CategoryTitle
    {
        get => _categoryTitle;
        private set => this.RaiseAndSetIfChanged(ref _categoryTitle, value);
    }

    public string ResultSummary
    {
        get => _resultSummary;
        private set => this.RaiseAndSetIfChanged(ref _resultSummary, value);
    }

    public int SelectedThemeIndex
    {
        get => _selectedThemeIndex;
        set
        {
            if (value < 0 || value >= Themes.Length || _selectedThemeIndex == value)
            {
                return;
            }

            this.RaiseAndSetIfChanged(ref _selectedThemeIndex, value);
            Workspace.IconTheme = Themes[value];
        }
    }

    public WorkspaceWindowViewModel Workspace { get; }

    public IconInfoRepository IconInfoRepository { get; }

    public string UrlPathSegment => Category;

    public IconCatalogPageViewModel(IScreen hostScreen, string category)
    {
        ArgumentNullException.ThrowIfNull(hostScreen);
        ArgumentException.ThrowIfNullOrWhiteSpace(category);

        HostScreen = hostScreen;
        Workspace = hostScreen as WorkspaceWindowViewModel ??
                    throw new ArgumentException(
                        $"{nameof(IconCatalogPageViewModel)} requires a {nameof(WorkspaceWindowViewModel)} host.",
                        nameof(hostScreen));
        Category = category;
        _selectedThemeIndex = Array.IndexOf(Themes, Workspace.IconTheme);
        if (_selectedThemeIndex < 0)
        {
            _selectedThemeIndex = 0;
        }

        IconInfoRepository = new IconInfoRepository
        {
            Category = category,
            IconTheme = Workspace.IconTheme
        };
        IconInfoRepository.RefreshIconInfos();
        IconInfoRepository.GetObservable(IconInfoRepository.MatchedIconCountProperty)
                          .Subscribe(_ => UpdateLocalizedText())
                          .DisposeWith(_subscriptions);
        Workspace.WhenAnyValue(workspace => workspace.IconTheme)
                 .DistinctUntilChanged()
                 .Subscribe(theme =>
                 {
                     var index = Array.IndexOf(Themes, theme);
                     if (index >= 0)
                     {
                         this.RaiseAndSetIfChanged(ref _selectedThemeIndex, index, nameof(SelectedThemeIndex));
                     }
                     IconInfoRepository.IconTheme = theme;
                 })
                 .DisposeWith(_subscriptions);

        _languageManager = Application.Current?.GetLanguageManager();
        if (_languageManager is not null)
        {
            _languageChangedHandler = (_, _) => UpdateLocalizedText();
            _languageManager.LanguageChanged += _languageChangedHandler;
        }
        UpdateLocalizedText();
    }

    private void UpdateLocalizedText()
    {
        CategoryTitle = MaterialGalleryModule.LocalizedCategory(Category).ToString();
        var resultFormat = new GalleryLocalizedText<IconCatalogPageLangResourceKind>(
                IconCatalogPageLangResourceKind.ResultsFormat,
                "{0:N0} icons")
            .ToString();
        ResultSummary = string.Format(resultFormat, IconInfoRepository.MatchedIconCount);
    }

    public void Dispose()
    {
        if (_isDisposed)
        {
            return;
        }

        _isDisposed = true;
        if (_languageManager is not null && _languageChangedHandler is not null)
        {
            _languageManager.LanguageChanged -= _languageChangedHandler;
        }
        _subscriptions.Dispose();
        IconInfoRepository.Dispose();
    }
}
