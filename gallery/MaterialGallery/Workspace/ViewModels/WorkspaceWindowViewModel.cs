using System.Reactive;
using AtomUI;
using AtomUI.Controls;
using AtomUI.Localization;
using AtomUI.Theme;
using AtomUI.Theme.Algorithms;
using AtomUI.Theme.Configuration;
using AtomUI.Theme.Resources;
using Avalonia;
using MaterialGallery.Models;
using ReactiveUI;

namespace MaterialGallery.Workspace.ViewModels;

public class WorkspaceWindowViewModel : ReactiveObject, IScreen
{
    private readonly IThemeManager? _themeManager;
    private readonly ILanguageManager? _languageManager;
    private bool _isDark;
    private bool _isCompact;
    private bool _isMotionEnabled = true;
    private bool _isWaveSpiritEnabled = true;
    private ThemeAlgorithm[] _baseAlgorithms = [ThemeAlgorithm.Default];
    private IReadOnlyList<string> _categoryKeys = [];

    public RoutingState Router { get; } = new RoutingState();

    public ReactiveCommand<bool, Unit> ToggleDarkModeCommand    { get; }
    public ReactiveCommand<bool, Unit> ToggleCompactModeCommand { get; }
    public ReactiveCommand<bool, Unit> ToggleMotionCommand      { get; }
    public ReactiveCommand<bool, Unit> ToggleWaveSpiritCommand  { get; }
    public ReactiveCommand<Unit, Unit> SwitchToZhCNCommand      { get; }
    public ReactiveCommand<Unit, Unit> SwitchToZhTWCommand      { get; }
    public ReactiveCommand<Unit, Unit> SwitchToEnUSCommand      { get; }
    public ReactiveCommand<Unit, Unit> SwitchToPtBRCommand      { get; }

    private bool _isZhCN;

    public bool IsZhCN
    {
        get => _isZhCN;
        private set => this.RaiseAndSetIfChanged(ref _isZhCN, value);
    }

    private bool _isZhTW;

    public bool IsZhTW
    {
        get => _isZhTW;
        private set => this.RaiseAndSetIfChanged(ref _isZhTW, value);
    }

    private bool _isEnUS;

    public bool IsEnUS
    {
        get => _isEnUS;
        private set => this.RaiseAndSetIfChanged(ref _isEnUS, value);
    }

    private bool _isPtBR;

    public bool IsPtBR
    {
        get => _isPtBR;
        private set => this.RaiseAndSetIfChanged(ref _isPtBR, value);
    }
    
    private List<IconCategory>? _categories;

    public List<IconCategory>? Categories
    {
        get => _categories;
        set => this.RaiseAndSetIfChanged(ref _categories, value);
    }
    
    private IconInfoRepository? _iconInfoRepository;

    public IconInfoRepository? IconInfoRepository
    {
        get => _iconInfoRepository;
        set => this.RaiseAndSetIfChanged(ref _iconInfoRepository, value);
    }

    public void SetCategoryKeys(IReadOnlyList<string> categoryKeys)
    {
        _categoryKeys = categoryKeys;
        RefreshCategories();
    }
    
    public WorkspaceWindowViewModel()
    {
        _themeManager    = Application.Current?.GetThemeManager();
        _languageManager = Application.Current?.GetLanguageManager();
        SyncThemeState(_themeManager?.CurrentTheme, null);
        SyncLanguageState(_languageManager?.Current);

        ToggleDarkModeCommand = ReactiveCommand.CreateFromTask<bool>(SetDarkModeAsync);

        ToggleCompactModeCommand = ReactiveCommand.CreateFromTask<bool>(SetCompactModeAsync);

        ToggleMotionCommand = ReactiveCommand.CreateFromTask<bool>(SetMotionEnabledAsync);

        ToggleWaveSpiritCommand = ReactiveCommand.CreateFromTask<bool>(SetWaveSpiritEnabledAsync);

        SwitchToZhCNCommand = ReactiveCommand.Create(() =>
            SetLanguage(LanguageTags.ZhCN));

        SwitchToZhTWCommand = ReactiveCommand.Create(() =>
            SetLanguage(LanguageTags.ZhTW));

        SwitchToEnUSCommand = ReactiveCommand.Create(() =>
            SetLanguage(LanguageTags.EnUS));

        SwitchToPtBRCommand = ReactiveCommand.Create(() =>
            SetLanguage(LanguageTags.PtBR));

        if (_themeManager is not null)
        {
            _themeManager.ThemeChanged += (_, args) => SyncThemeState(args.State, args.Request.Config);
        }
        if (_languageManager is not null)
        {
            _languageManager.LanguageChanged += (_, args) => SyncLanguageState(args.Result.NewState);
        }
    }

    private async Task SetDarkModeAsync(bool isDark)
    {
        _isDark = isDark;
        await ApplyThemeSettingsAsync();
    }

    private async Task SetCompactModeAsync(bool isCompact)
    {
        _isCompact = isCompact;
        await ApplyThemeSettingsAsync();
    }

    private async Task SetMotionEnabledAsync(bool enabled)
    {
        _isMotionEnabled = enabled;
        if (!enabled)
        {
            _isWaveSpiritEnabled = false;
        }
        await ApplyThemeSettingsAsync();
    }

    private async Task SetWaveSpiritEnabledAsync(bool enabled)
    {
        if (enabled)
        {
            _isMotionEnabled = true;
        }
        _isWaveSpiritEnabled = enabled;
        await ApplyThemeSettingsAsync();
    }

    private async Task ApplyThemeSettingsAsync()
    {
        if (_themeManager is null)
        {
            return;
        }

        var algorithms = new List<ThemeAlgorithm>(_baseAlgorithms.Length + 2);
        algorithms.AddRange(_baseAlgorithms);
        if (_isCompact)
        {
            algorithms.Add(ThemeAlgorithm.Compact);
        }
        if (_isDark)
        {
            algorithms.Add(ThemeAlgorithm.Dark);
        }

        var config = new ThemeConfigBuilder()
                     .WithAlgorithms(algorithms.ToArray())
                     .WithToken(nameof(SharedTokenKind.EnableMotion), _isMotionEnabled ? "true" : "false")
                     .WithToken(nameof(SharedTokenKind.EnableWaveSpirit), _isWaveSpiritEnabled ? "true" : "false")
                     .Build();
        var result = await _themeManager.ApplyThemeAsync(
            new ThemeRequest(
                _themeManager.CurrentTheme?.ThemeId ?? IThemeManager.DEFAULT_THEME_ID,
                config,
                ThemeTransitionReason.UserRequest));
        if (result.Status == ThemeTransitionStatus.Failed)
        {
            var message = string.Join(" ", result.Diagnostics.Select(static diagnostic => diagnostic.Message));
            throw new ThemeLoadException(message, result.Exception);
        }
    }

    private void SyncThemeState(ThemeState? state, ThemeConfig? config)
    {
        if (state is not null)
        {
            _isDark    = state.Appearance == ThemeAppearance.Dark;
            _isCompact = state.Algorithms.Contains(ThemeAlgorithm.Compact);
            _baseAlgorithms = state.Algorithms
                                   .Where(static algorithm =>
                                       algorithm is not ThemeAlgorithm.Compact and not ThemeAlgorithm.Dark)
                                   .ToArray();
            if (_baseAlgorithms.Length == 0)
            {
                _baseAlgorithms = [ThemeAlgorithm.Default];
            }
        }

        _isMotionEnabled     = ReadBooleanToken(config, nameof(SharedTokenKind.EnableMotion), true);
        _isWaveSpiritEnabled = _isMotionEnabled &&
                               ReadBooleanToken(config, nameof(SharedTokenKind.EnableWaveSpirit), true);
    }

    private static bool ReadBooleanToken(ThemeConfig? config, string name, bool defaultValue)
    {
        return config is not null &&
               config.Tokens.TryGetValue(name, out var value) &&
               bool.TryParse(value, out var parsed)
            ? parsed
            : defaultValue;
    }

    private void SyncLanguageState(LanguageState? state)
    {
        IsZhCN = state?.CurrentLanguage == LanguageTags.ZhCN;
        IsZhTW = state?.CurrentLanguage == LanguageTags.ZhTW;
        IsEnUS = state?.CurrentLanguage == LanguageTags.EnUS;
        IsPtBR = state?.CurrentLanguage == LanguageTags.PtBR;
        RefreshCategories();
    }

    private void RefreshCategories()
    {
        if (_categoryKeys.Count > 0)
        {
            Categories = IconCategoryLocalization.Localize(_categoryKeys);
        }
    }

    private void SetLanguage(LanguageTag language)
    {
        if (_languageManager is not null)
        {
            _languageManager.ChangeLanguage(language);
        }
    }
}
