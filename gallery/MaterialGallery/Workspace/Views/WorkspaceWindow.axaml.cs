using System.Reactive;
using AtomUI.Desktop.Controls;
using AtomUI.Toolkits.GalleryBase.Controls;
using AtomUI.Toolkits.GalleryBase.Shell;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MaterialGallery.Workspace.ViewModels;
using MenuItem = AtomUI.Desktop.Controls.MenuItem;

namespace MaterialGallery.Workspace.Views;

internal enum WindowMenuItemKind
{
    FullScreen,
    Pin,
    Minimize,
    Maximize,
    Move,
    Resize,
    DarkMode,
    Compact,
    Motion,
    WaveSpirit,
    LanguageZhCN,
    LanguageZhTW,
    LanguageEnUS,
    LanguagePtBR,
}

public partial class WorkspaceWindow : ReactiveWindow<WorkspaceWindowViewModel>
{
    public const string LanguageId = nameof(WorkspaceWindow);
    private const string TitleBarMenuResourceKey = "WorkspaceTitleBarMenu";
    private GalleryShellView? _shellView;
    private bool _released;

    public WorkspaceWindow()
    {
        ViewModel = new WorkspaceWindowViewModel();
        InitializeComponent();
        BuildContent();
    }

    private void BuildContent()
    {
        if (ViewModel is null || _shellView is not null)
        {
            return;
        }

        var navigation = new CaseNavigation
        {
            Name      = "CategoryNavigation",
            ViewModel = ViewModel.CaseNavigation
        };
        _shellView = new GalleryShellView(
            MaterialGalleryModule.GetConfiguration(),
            navigation,
            ViewModel.Router);
        ShellHost.Children.Add(_shellView);
    }

    protected override WindowTitleBar? NotifyCreateTitleBar(WindowTitleBar? oldTitleBar)
    {
        return new GalleryWindowTitleBar { Name = "PART_TitleBar" };
    }

    protected override void NotifyConfigureTitleBar(WindowTitleBar titleBar)
    {
        base.NotifyConfigureTitleBar(titleBar);
        if (titleBar is GalleryWindowTitleBar galleryTitleBar &&
            Resources.TryGetValue(TitleBarMenuResourceKey, out var menu))
        {
            galleryTitleBar.Menu = menu as Control;
        }
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        AddHandler(MenuItem.ClickEvent, HandleMenuItemClick);
    }

    protected override void OnClosed(EventArgs e)
    {
        ReleaseWorkspace();
        base.OnClosed(e);
    }

    private void ReleaseWorkspace()
    {
        if (_released)
        {
            return;
        }
        _released = true;
        RemoveHandler(MenuItem.ClickEvent, HandleMenuItemClick);
        _shellView?.Dispose();
        _shellView = null;
        ViewModel?.Dispose();
    }

    private void HandleMenuItemClick(object? sender, RoutedEventArgs e)
    {
        if (ViewModel is null || e.Source is not MenuItem menuItem ||
            menuItem.Tag is not WindowMenuItemKind kind ||
            menuItem.ToggleType == MenuItemToggleType.None)
        {
            return;
        }

        switch (kind)
        {
            case WindowMenuItemKind.FullScreen:
                IsFullScreenCaptionButtonVisible = menuItem.IsChecked;
                break;
            case WindowMenuItemKind.Pin:
                IsPinCaptionButtonVisible = menuItem.IsChecked;
                break;
            case WindowMenuItemKind.Minimize:
                IsMinimizeCaptionButtonVisible = menuItem.IsChecked;
                break;
            case WindowMenuItemKind.Maximize:
                IsMaximizeCaptionButtonVisible = menuItem.IsChecked;
                break;
            case WindowMenuItemKind.Move:
                IsMoveEnabled = menuItem.IsChecked;
                break;
            case WindowMenuItemKind.Resize:
                CanResize = menuItem.IsChecked;
                break;
            case WindowMenuItemKind.DarkMode:
                ViewModel.ToggleDarkModeCommand.Execute(menuItem.IsChecked).Subscribe();
                break;
            case WindowMenuItemKind.Compact:
                ViewModel.ToggleCompactModeCommand.Execute(menuItem.IsChecked).Subscribe();
                break;
            case WindowMenuItemKind.Motion:
                ViewModel.ToggleMotionCommand.Execute(menuItem.IsChecked).Subscribe();
                break;
            case WindowMenuItemKind.WaveSpirit:
                ViewModel.ToggleWaveSpiritCommand.Execute(menuItem.IsChecked).Subscribe();
                break;
            case WindowMenuItemKind.LanguageZhCN:
                ViewModel.SwitchToZhCNCommand.Execute(Unit.Default).Subscribe();
                break;
            case WindowMenuItemKind.LanguageZhTW:
                ViewModel.SwitchToZhTWCommand.Execute(Unit.Default).Subscribe();
                break;
            case WindowMenuItemKind.LanguageEnUS:
                ViewModel.SwitchToEnUSCommand.Execute(Unit.Default).Subscribe();
                break;
            case WindowMenuItemKind.LanguagePtBR:
                ViewModel.SwitchToPtBRCommand.Execute(Unit.Default).Subscribe();
                break;
        }
    }
}
