using ReactiveUI;

namespace MaterialGallery.Workspace.ViewModels;

public sealed class MaterialIconPageViewModel : ReactiveObject, IRoutableViewModel
{
    public IScreen HostScreen { get; }

    public string Category { get; }

    public string UrlPathSegment => Category;

    public MaterialIconPageViewModel(IScreen hostScreen, string category)
    {
        ArgumentNullException.ThrowIfNull(hostScreen);
        ArgumentException.ThrowIfNullOrWhiteSpace(category);

        HostScreen = hostScreen;
        Category   = category;
    }
}
