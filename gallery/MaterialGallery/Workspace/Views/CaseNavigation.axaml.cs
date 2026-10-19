using System.Reactive.Disposables;
using System.Reactive.Disposables.Fluent;
using AtomUI;
using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using AtomUI.Localization;
using AtomUI.Toolkits.GalleryBase.Controls;
using AtomUI.Toolkits.GalleryBase.Navigation;
using AtomUI.Toolkits.GalleryBase.Shell;
using Avalonia;
using Avalonia.Controls;
using MaterialGallery.Workspace.ViewModels;
using ComboBox = AtomUI.Desktop.Controls.ComboBox;
using ComboBoxItem = AtomUI.Desktop.Controls.ComboBoxItem;

namespace MaterialGallery.Workspace.Views;

public partial class CaseNavigation : GalleryReactiveUserControl<CaseNavigationViewModel>,
                                      IGallerySidebarNavMenuHost
{
    private readonly ComboBox _iconThemeSelector;
    private ILanguageManager? _subscribedLanguageManager;
    private EventHandler<LanguageChangedEventArgs>? _languageChangedHandler;

    NavMenu IGallerySidebarNavMenuHost.SidebarNavMenu => CategoryNavMenu;
    Control IGallerySidebarNavMenuHost.SidebarHeaderAction => _iconThemeSelector;

    public CaseNavigation()
    {
        InitializeComponent();
        _iconThemeSelector = CreateIconThemeSelector();
        ConfigureNavigationMenu();

        this.WhenActivated(disposables =>
        {
            void NavMenuItemClickHandler(object? sender, NavMenuItemClickEventArgs args)
            {
                var key = args.NavMenuItem.ItemKey;
                if (key.HasValue && ViewModel is not null && ViewModel.CanNavigateTo(key.Value))
                {
                    ViewModel.NavigateToCommand.Execute(key.Value)
                             .Subscribe()
                             .DisposeWith(disposables);
                }
            }

            CategoryNavMenu.NavMenuItemClick += NavMenuItemClickHandler;
            Disposable.Create(() => CategoryNavMenu.NavMenuItemClick -= NavMenuItemClickHandler)
                      .DisposeWith(disposables);
        });
    }

    private ComboBox CreateIconThemeSelector()
    {
        var selector = new ComboBox
        {
            Name          = "IconThemeSelector",
            Width         = 150,
            SelectedIndex = 0
        };
        IconThemeType[] materialThemes =
        [
            IconThemeType.Filled,
            IconThemeType.Outlined,
            IconThemeType.Rounded,
            IconThemeType.Sharp,
            IconThemeType.TwoTone
        ];
        foreach (var iconTheme in materialThemes)
        {
            selector.Items.Add(new ComboBoxItem
            {
                Content = iconTheme.ToString(),
                Tag     = iconTheme
            });
        }
        selector.SelectionChanged += HandleIconThemeSelectionChanged;
        return selector;
    }

    private void HandleIconThemeSelectionChanged(object? sender, SelectionChangedEventArgs args)
    {
        if (ViewModel is not null &&
            _iconThemeSelector.SelectedItem is ComboBoxItem { Tag: IconThemeType theme })
        {
            ViewModel.Workspace.IconTheme = theme;
        }
    }

    private void ConfigureNavigationMenu()
    {
        var configuration = MaterialGalleryModule.GetConfiguration();
        var adapter = new GalleryNavigationMenuAdapter();

        CategoryNavMenu.Items.Clear();
        foreach (var node in adapter.BuildNodes(configuration.NavigationNodes))
        {
            CategoryNavMenu.Items.Add(node);
        }
        CategoryNavMenu.DefaultOpenPaths = adapter.BuildDefaultOpenPaths(configuration.DefaultOpenKeys);
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        SubscribeLanguageChanged();
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        UnsubscribeLanguageChanged();
        base.OnDetachedFromVisualTree(e);
    }

    private void SubscribeLanguageChanged()
    {
        if (_subscribedLanguageManager is not null)
        {
            return;
        }

        _subscribedLanguageManager = Application.Current?.GetLanguageManager();
        if (_subscribedLanguageManager is null)
        {
            return;
        }

        _languageChangedHandler = (_, _) => ConfigureNavigationMenu();
        _subscribedLanguageManager.LanguageChanged += _languageChangedHandler;
    }

    private void UnsubscribeLanguageChanged()
    {
        if (_subscribedLanguageManager is null || _languageChangedHandler is null)
        {
            return;
        }

        _subscribedLanguageManager.LanguageChanged -= _languageChangedHandler;
        _subscribedLanguageManager = null;
        _languageChangedHandler = null;
    }
}
