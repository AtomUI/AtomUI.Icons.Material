using ReactiveUI;

namespace MaterialGallery.Features.Overview;

public sealed class OverviewViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Overview";

    public IScreen HostScreen { get; }

    public string UrlPathSegment => ID;

    public OverviewViewModel(IScreen screen)
    {
        HostScreen = screen ?? throw new ArgumentNullException(nameof(screen));
    }
}
