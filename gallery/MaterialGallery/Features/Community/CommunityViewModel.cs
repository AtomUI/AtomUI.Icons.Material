using ReactiveUI;

namespace MaterialGallery.Features.Community;

public sealed class CommunityViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Community";

    public IScreen HostScreen { get; }

    public string UrlPathSegment => ID;

    public Uri GitHubUri { get; } = new(GalleryProjectLinks.GitHub);

    public Uri IssuesUri { get; } = new(GalleryProjectLinks.Issues);

    public Uri NuGetUri { get; } = new(GalleryProjectLinks.NuGetPackage);

    public Uri WebsiteUri { get; } = new(GalleryProjectLinks.Website);

    public Uri AtomUIUri { get; } = new(GalleryProjectLinks.AtomUI);

    public CommunityViewModel(IScreen screen)
    {
        HostScreen = screen ?? throw new ArgumentNullException(nameof(screen));
    }
}
