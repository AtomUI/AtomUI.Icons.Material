using AtomUI.Toolkits.GalleryBase.Navigation;
using ReactiveUI;

namespace MaterialGallery.Workspace.ViewModels;

public sealed class CaseNavigationViewModel : GalleryNavigationViewModel
{
    public WorkspaceWindowViewModel Workspace => (WorkspaceWindowViewModel)HostScreen;

    public CaseNavigationViewModel(IScreen hostScreen)
        : base(hostScreen, MaterialGalleryModule.GetConfiguration())
    {
    }
}
