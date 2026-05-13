using System.Reactive;
using AtomUI.Desktop.Controls;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;
using Avalonia.Threading;
using MaterialGallery.Controls;
using MaterialGallery.Models;
using MaterialGallery.Workspace.ViewModels;
using MenuItemToggleType = Avalonia.Controls.MenuItemToggleType;

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
    LanguageEnUS,
}

public partial class WorkspaceWindow : ReactiveWindow<WorkspaceWindowViewModel>
{
    public const string LanguageId = nameof(WorkspaceWindow);

    static WorkspaceWindow()
    {
        IconInfoItem.ClickedEvent.AddClassHandler<WorkspaceWindow>((window, args) =>
        {
            if (args.Source is IconInfoItem iconInfoItem)
            {
                window.HandleIconItemClicked(iconInfoItem);
            }
        });
    }
    
    private WindowMessageManager? _messageManager;
    private bool _iconRepositoryInitializationQueued;
    private bool _menuItemClickHandlerAttached;
    
    public WorkspaceWindow()
    {
        ViewModel = new WorkspaceWindowViewModel();
        InitializeComponent();
        _messageManager =  new WindowMessageManager(this);
    }

    private void HandleIconItemClicked(IconInfoItem infoItem)
    {
        _messageManager?.Show(
            new Message(
                type: MessageType.Success,
            content:$"<{infoItem.IconName} /> copied 🎉"
        ));
        if (Clipboard != null)
        {
            Dispatcher.InvokeAsync(async () =>
            {
                await Clipboard.SetTextAsync(infoItem.IconName);
            });
        }
    }

    public override void Show()
    {
        base.Show();
        Height = double.NaN;
        Width  = double.NaN;
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        if (!_menuItemClickHandlerAttached)
        {
            AddHandler(MenuItem.ClickEvent, HandleMenuItemClick);
            _menuItemClickHandlerAttached = true;
        }

        QueueIconRepositoryInitialization();
    }

    private void QueueIconRepositoryInitialization()
    {
        if (_iconRepositoryInitializationQueued)
        {
            return;
        }

        _iconRepositoryInitializationQueued = true;
        Dispatcher.Post(InitializeIconRepository, DispatcherPriority.Background);
    }

    private void InitializeIconRepository()
    {
        if (ViewModel is not { } viewModel || viewModel.IconInfoRepository != null)
        {
            return;
        }

        var repository = new IconInfoRepository();
        viewModel.IconInfoRepository = repository;
        viewModel.Categories         = repository.Categories;
    }

    private void HandleMenuItemClick(object? sender, RoutedEventArgs e)
    {
        if (ViewModel is null) return;

        if (e.Source is MenuItem menuItem && menuItem.Tag is WindowMenuItemKind kind)
        {
            if (menuItem.ToggleType == MenuItemToggleType.None) return;

            switch (kind)
            {
                case WindowMenuItemKind.FullScreen:
                    IsFullScreenCaptionButtonVisible = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Pin:
                    IsPinCaptionButtonVisible = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Minimize:
                    CanMinimize = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Maximize:
                    CanMaximize = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Move:
                    IsMoveEnabled = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Resize:
                    CanResize = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.DarkMode:
                    ViewModel.ToggleDarkModeCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.Compact:
                    ViewModel.ToggleCompactModeCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.Motion:
                    if (menuItem.Parent is MenuItem themeMenuItem)
                    {
                        foreach (var item in themeMenuItem.Items)
                        {
                            if (item is MenuItem themeMenuChildItem &&
                                themeMenuChildItem.Tag is WindowMenuItemKind childKind &&
                                childKind == WindowMenuItemKind.WaveSpirit)
                            {
                                if (!menuItem.IsChecked)
                                {
                                    themeMenuChildItem.IsChecked = false;
                                }
                            }
                        }
                    }
                    ViewModel.ToggleMotionCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.WaveSpirit:
                    ViewModel.ToggleWaveSpiritCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.LanguageZhCN:
                    ViewModel.SwitchToZhCNCommand.Execute(Unit.Default)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.LanguageEnUS:
                    ViewModel.SwitchToEnUSCommand.Execute(Unit.Default)
                             .Subscribe();
                    break;
            }
        }
    }
}
