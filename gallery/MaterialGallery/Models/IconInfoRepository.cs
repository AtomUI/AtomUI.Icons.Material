using AtomUI.Controls;
using Avalonia;
using Avalonia.Collections;

namespace MaterialGallery.Models;

public partial class IconInfoRepository : AvaloniaObject
{
    private const int InitialIconLoadCount     = 96;
    private const int IncrementalIconLoadCount = 96;

    #region 公共属性定义

    public static readonly StyledProperty<string?> CategoryProperty = 
        AvaloniaProperty.Register<IconInfoRepository, string?>(nameof (Category), "Action");
    
    public static readonly StyledProperty<IconThemeType> IconThemeProperty = 
        AvaloniaProperty.Register<IconInfoRepository, IconThemeType>(nameof (IconTheme));
    
    public static readonly StyledProperty<IEnumerable<IconInfo>?> ActivatedIconInfosProperty = 
        AvaloniaProperty.Register<IconInfoRepository, IEnumerable<IconInfo>?>(nameof (ActivatedIconInfos));
    
    public static readonly StyledProperty<string?> FilterProperty =
        AvaloniaProperty.Register<IconInfoRepository, string?>(nameof (Filter));
    
    public string? Category
    {
        get => GetValue(CategoryProperty);
        set => SetValue(CategoryProperty, value);
    }
    
    public IconThemeType IconTheme
    {
        get => GetValue(IconThemeProperty);
        set => SetValue(IconThemeProperty, value);
    }

    public IEnumerable<IconInfo>? ActivatedIconInfos
    {
        get => GetValue(ActivatedIconInfosProperty);
        set => SetValue(ActivatedIconInfosProperty, value);
    }
    
    public string? Filter
    {
        get => GetValue(FilterProperty);
        set => SetValue(FilterProperty, value);
    }
    
    #endregion

    public List<string> Categories { get; set; } = new();

    private List<IconInfo> _matchedIconInfos = new();
    private AvaloniaList<IconInfo> _activatedIconInfos = new();
    private int _loadedIconCount;

    public bool HasMoreIconInfos => _loadedIconCount < _matchedIconInfos.Count;

    public void RefreshIconInfos()
    {
        HandleCondChanged();
    }
    
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == CategoryProperty ||
            change.Property == IconThemeProperty ||
            change.Property == FilterProperty)
        {
            HandleCondChanged();
        }
    }

    private void HandleCondChanged()
    {
        ResetActivatedIconInfos();

        _matchedIconInfos = CreateIconInfos(Category, IconTheme);
        if (!string.IsNullOrEmpty(Filter))
        {
            _matchedIconInfos = _matchedIconInfos
                .Where(info => info.Name.Contains(Filter, StringComparison.InvariantCultureIgnoreCase))
                .ToList();
        }

        LoadMoreIconInfos(InitialIconLoadCount);
    }

    public void LoadMoreIconInfos()
    {
        LoadMoreIconInfos(IncrementalIconLoadCount);
    }

    private void LoadMoreIconInfos(int count)
    {
        if (!HasMoreIconInfos)
        {
            return;
        }

        var targetCount = Math.Min(_loadedIconCount + count, _matchedIconInfos.Count);
        for (var i = _loadedIconCount; i < targetCount; i++)
        {
            var iconInfo = _matchedIconInfos[i];
            iconInfo.Icon = iconInfo.Creator?.Invoke();
            _activatedIconInfos.Add(iconInfo);
        }

        _loadedIconCount = targetCount;
    }

    private void ResetActivatedIconInfos()
    {
        foreach (var iconInfo in _activatedIconInfos)
        {
            iconInfo.Icon = null;
        }

        _loadedIconCount    = 0;
        _activatedIconInfos = new AvaloniaList<IconInfo>();
        SetCurrentValue(ActivatedIconInfosProperty, _activatedIconInfos);
    }

    protected partial List<IconInfo> CreateIconInfos(string? category, IconThemeType iconTheme);
}
