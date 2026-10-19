using AtomUI;
using MaterialGallery.Workspace.Views;
using Window = Avalonia.Controls.Window;

namespace MaterialGallery.Desktop;

public partial class GalleryApplication : BaseGalleryApplication
{
    public GalleryApplication()
    {
        Name = "Material Icons Gallery";
    }
    public static void Configure(IAtomUIBuilder builder)
    {
        BaseGalleryApplication.ConfigureCore(builder);
        builder.UseMainWindow(static _ => Task.FromResult<Window>(new WorkspaceWindow()));
    }
}
