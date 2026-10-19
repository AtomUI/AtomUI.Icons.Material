using ReactiveUI;
using MaterialGallery.Models;

namespace MaterialGallery.Features.Overview;

public sealed class OverviewViewModel : ReactiveObject, IRoutableViewModel
{
    private const string MaterialPackageName = "AtomUI.Icons.Material";

    public const string ID = "Overview";

    public IScreen HostScreen { get; }

    public string UrlPathSegment => ID;

    public string PackageName => MaterialPackageName;

    public string DotNetCliInstallCommand =>
        $"dotnet add package {MaterialPackageName} --version {GalleryVersionInfo.Version}";

    public string PackageReferenceInstallCommand =>
        $"<PackageReference Include=\"{MaterialPackageName}\" Version=\"{GalleryVersionInfo.Version}\" />";

    public string PackageManagerInstallCommand =>
        $"Install-Package {MaterialPackageName} -Version {GalleryVersionInfo.Version}";

    public Uri BrowseIconsUri { get; } = new($"{GalleryProjectLinks.GitHub}/tree/main/src/AtomUI.Icons.Material");

    public Uri UsageUri { get; } = new($"{GalleryProjectLinks.GitHub}#readme");

    public Uri NuGetUri { get; } = new(GalleryProjectLinks.NuGetPackage);

    public Uri GitHubUri { get; } = new(GalleryProjectLinks.GitHub);

    public OverviewViewModel(IScreen screen)
    {
        HostScreen = screen ?? throw new ArgumentNullException(nameof(screen));
    }
}
