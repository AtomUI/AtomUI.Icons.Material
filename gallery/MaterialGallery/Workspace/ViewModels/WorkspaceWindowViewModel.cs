using AtomUI.Controls;
using AtomUI.Toolkits.GalleryBase.Shell;
using System.Reactive.Linq;
using ReactiveUI;

namespace MaterialGallery.Workspace.ViewModels;

public sealed class WorkspaceWindowViewModel : GalleryWorkspaceViewModel
{
    private IconThemeType _iconTheme = IconThemeType.Filled;
    private readonly IDisposable _routeLifecycleSubscription;

    public CaseNavigationViewModel CaseNavigation => (CaseNavigationViewModel)Navigation;

    public IconThemeType IconTheme
    {
        get => _iconTheme;
        set => this.RaiseAndSetIfChanged(ref _iconTheme, value);
    }

    public WorkspaceWindowViewModel()
        : base(MaterialGalleryModule.GetConfiguration(), screen => new CaseNavigationViewModel(screen))
    {
        IRoutableViewModel? previousRoute = null;
        _routeLifecycleSubscription = Router.CurrentViewModel
            .Subscribe(currentRoute =>
            {
                if (!ReferenceEquals(previousRoute, currentRoute) && previousRoute is IDisposable disposable)
                {
                    disposable.Dispose();
                }
                previousRoute = currentRoute;
            });
    }

    public override void Dispose()
    {
        _routeLifecycleSubscription.Dispose();
        (Router.GetCurrentViewModel() as IDisposable)?.Dispose();
        base.Dispose();
    }
}
