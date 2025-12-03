using AtomUI.Controls;
using Avalonia;

namespace MaterialGallery.Models;

public partial class IconInfoRepository : AvaloniaObject
{
    #region 公共属性定义

    public static readonly StyledProperty<string?> CategoryProperty = 
        AvaloniaProperty.Register<IconInfoRepository, string?>(nameof (Category));
    
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

    protected List<IconInfo> IconInfos { get; set; } = new();
    public List<string> Categories { get; set; } = new();
    
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
        if (ActivatedIconInfos != null)
        {
            foreach (var iconInfo in ActivatedIconInfos)
            {
                iconInfo.Icon = null;
            }
        }

        var iconInfos = IconInfos.Where(info => info.ThemeType == IconTheme && 
                                                (string.IsNullOrEmpty(Category) || info.Category == Category) && 
                                                (string.IsNullOrEmpty(Filter) || info.Name.Contains(Filter, StringComparison.InvariantCultureIgnoreCase))).Select(info =>
        {
            info.Icon = info.Creator?.Invoke();
            return info;
        }).ToList();
        SetCurrentValue(ActivatedIconInfosProperty, iconInfos);
    }
}