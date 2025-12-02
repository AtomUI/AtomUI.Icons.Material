using System.Collections;
using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using AtomUI.Desktop.Controls.Primitives;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Threading;
using MaterialGallery.Controls.Themes;
using ComboBox = AtomUI.Desktop.Controls.ComboBox;
using ComboBoxItem = AtomUI.Desktop.Controls.ComboBoxItem;

namespace MaterialGallery.Controls;

public class Navigation : TemplatedControl
{
    #region 公共属性定义

    public static readonly StyledProperty<List<string>?> CategoriesProperty = 
        AvaloniaProperty.Register<Navigation, List<string>?>(nameof (Categories));
    
    public static readonly StyledProperty<string?> CategoryProperty = 
        AvaloniaProperty.Register<Navigation, string?>(nameof (Category), "Action");
    
    public static readonly StyledProperty<IconThemeType> IconThemeProperty = 
        AvaloniaProperty.Register<Navigation, IconThemeType>(nameof (IconTheme));

    public List<string>? Categories
    {
        get => GetValue(CategoriesProperty);
        set => SetValue(CategoriesProperty, value);
    }
    
    public string? Category
    {
        get => GetValue(CategoryProperty);
        protected set => SetValue(CategoryProperty, value);
    }
    
    public IconThemeType IconTheme
    {
        get => GetValue(IconThemeProperty);
        protected set => SetValue(IconThemeProperty, value);
    }
    #endregion
    
    public event EventHandler<NavigateRequestEventArgs>? NavigateRequest;

    #region 内部属性定义

    public static readonly StyledProperty<IEnumerable?> CategoryMavMenuItemsProperty = 
        AvaloniaProperty.Register<Navigation, IEnumerable?>(nameof (CategoryMavMenuItems));

    public IEnumerable? CategoryMavMenuItems
    {
        get => GetValue(CategoryMavMenuItemsProperty);
        set => SetValue(CategoriesProperty, value);
    }
    
    #endregion
    
    private ComboBox? _themeComboBox;
    private NavMenu? _categoryNavMenu;

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == CategoriesProperty)
        {
            HandleCategoriesChanged();
        }
        else if (change.Property == IconThemeProperty ||
                 change.Property == CategoryProperty)
        {
            HandleCondChanged(Category, IconTheme);
        }
    }

    private void HandleCategoriesChanged()
    {
        if (Categories != null)
        {
            var menuItems= new List<NavMenuItemData>();
        
            foreach (var category in Categories)
            {
                menuItems.Add(new NavMenuItemData()
                {
                    Header = category,
                    ItemKey = category,
                });
            }
            SetCurrentValue(CategoryMavMenuItemsProperty, menuItems);
        }
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        _categoryNavMenu = e.NameScope.Find<NavMenu>(NavigationThemeConstants.CategoryNavMenuPart);
        _themeComboBox = e.NameScope.Find<ComboBox>(NavigationThemeConstants.IconThemeComboBoxPart);
        if (_categoryNavMenu != null)
        {
            _categoryNavMenu.NavMenuItemSelected += (sender, args) =>
            {
                SetCurrentValue(CategoryProperty, args.NavMenuItem.ItemKey.ToString());
            };
            _categoryNavMenu.DefaultSelectedPath = new TreeNodePath("/Action");
        }

        if (_themeComboBox != null)
        {
            _themeComboBox.SelectionChanged += (sender, args) =>
            {
                if (_themeComboBox.SelectedItem is ComboBoxItem item)
                {
                    SetCurrentValue(IconThemeProperty, (item.Tag as IconThemeType?)!);
                }
            };
            _themeComboBox.DropDownOpened += (sender, args) =>
            {
                if (_themeComboBox.SelectedItem is ComboBoxItem item)
                {
                    SetCurrentValue(IconThemeProperty, (item.Tag as IconThemeType?)!);
                }
            };
        }
    }

    private void HandleCondChanged(string? category, IconThemeType iconTheme)
    {
        Dispatcher.UIThread.Post(() => NavigateRequest?.Invoke(this, new NavigateRequestEventArgs(category, iconTheme)));
    }
}