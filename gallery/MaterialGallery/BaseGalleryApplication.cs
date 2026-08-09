using Avalonia;
using MaterialGallery.Workspace.Views;

namespace MaterialGallery;

public abstract partial class BaseGalleryApplication : Application
{
    public BaseGalleryApplication()
    {
    }

    protected WorkspaceWindow CreateWorkspaceWindow()
    {
        return new WorkspaceWindow();
    }
}
