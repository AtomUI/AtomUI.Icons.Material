using System.Reactive.Disposables;
using System.Reactive.Disposables.Fluent;
using AtomUI;
using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using AtomUI.Icons.AntDesign;
using AtomUI.Localization;
using AtomUI.Toolkits.GalleryBase.Controls;
using AtomUI.Toolkits.GalleryBase.Localization;
using AtomUI.Toolkits.GalleryBase.Navigation;
using AtomUI.Toolkits.GalleryBase.Shell;
using Avalonia;
using Avalonia.Automation;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using MaterialGallery.Localization;
using MaterialGallery.Workspace.ViewModels;
using DesktopButton = AtomUI.Desktop.Controls.Button;

namespace MaterialGallery.Workspace.Views;

public partial class CaseNavigation : GalleryReactiveUserControl<CaseNavigationViewModel>,
                                      IGallerySidebarNavMenuHost
{
    private readonly PathIcon _collapseNavigationIcon;
    private readonly PathIcon _expandNavigationIcon;
    private readonly DesktopButton _navigationCollapseButton;
    private ILanguageManager? _subscribedLanguageManager;
    private EventHandler<LanguageChangedEventArgs>? _languageChangedHandler;

    NavMenu IGallerySidebarNavMenuHost.SidebarNavMenu => CategoryNavMenu;
    Control IGallerySidebarNavMenuHost.SidebarHeaderAction => _navigationCollapseButton;

    public CaseNavigation()
    {
        InitializeComponent();
        _collapseNavigationIcon = CreateNavigationIcon(AntDesignIconKind.MenuFoldOutlined);
        _expandNavigationIcon   = CreateNavigationIcon(AntDesignIconKind.MenuUnfoldOutlined);
        _navigationCollapseButton = new DesktopButton
        {
            Name                = "NavigationCollapseButton",
            Width               = 40,
            Height              = 40,
            ButtonType          = ButtonType.Text,
            HorizontalAlignment = HorizontalAlignment.Center,
            VerticalAlignment   = VerticalAlignment.Center
        };
        _navigationCollapseButton.Click += HandleToggleNavigationCollapsedClick;
        ConfigureNavigationMenu();
        UpdateNavigationCollapseButtonPresentation();

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
            CategoryNavMenu.GetObservable(NavMenu.IsInlineCollapsedProperty)
                           .Subscribe(_ => UpdateNavigationCollapseButtonPresentation())
                           .DisposeWith(disposables);
        });
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

        _languageChangedHandler = (_, _) =>
        {
            ConfigureNavigationMenu();
            UpdateNavigationCollapseButtonPresentation();
        };
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

    private void HandleToggleNavigationCollapsedClick(object? sender, RoutedEventArgs e)
    {
        CategoryNavMenu.IsInlineCollapsed = !CategoryNavMenu.IsInlineCollapsed;
        UpdateNavigationCollapseButtonPresentation();
    }

    private void UpdateNavigationCollapseButtonPresentation()
    {
        var isCollapsed = CategoryNavMenu.IsInlineCollapsed;
        var resourceKind = isCollapsed
            ? WorkspaceWindowLangResourceKind.ExpandNavigation
            : WorkspaceWindowLangResourceKind.CollapseNavigation;
        var fallback = isCollapsed ? "Expand navigation" : "Collapse navigation";
        var accessibleText = new GalleryLocalizedText<WorkspaceWindowLangResourceKind>(resourceKind, fallback)
            .Resolve()
            .ToString();

        _navigationCollapseButton.Icon = isCollapsed
            ? _expandNavigationIcon
            : _collapseNavigationIcon;
        AutomationProperties.SetName(_navigationCollapseButton, accessibleText);
    }

    private static PathIcon CreateNavigationIcon(AntDesignIconKind iconKind)
    {
        return (PathIcon)new AntDesignIconProvider(iconKind).ProvideValue(null!);
    }
}
