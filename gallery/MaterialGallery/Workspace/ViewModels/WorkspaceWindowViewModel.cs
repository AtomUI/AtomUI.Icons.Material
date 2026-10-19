using AtomUI.Controls;
using AtomUI.Toolkits.GalleryBase.Shell;
using ReactiveUI;

namespace MaterialGallery.Workspace.ViewModels;

public sealed class WorkspaceWindowViewModel : GalleryWorkspaceViewModel
{
    private IconThemeType _iconTheme = IconThemeType.Filled;

    public CaseNavigationViewModel CaseNavigation => (CaseNavigationViewModel)Navigation;

    public IconThemeType IconTheme
    {
        get => _iconTheme;
        set => this.RaiseAndSetIfChanged(ref _iconTheme, value);
    }

    public WorkspaceWindowViewModel()
        : base(MaterialGalleryModule.GetConfiguration(), screen => new CaseNavigationViewModel(screen))
    {
    }
}
