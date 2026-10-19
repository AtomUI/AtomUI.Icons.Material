using System.Reflection;

namespace MaterialGallery;

public static class GalleryVersionInfo
{
    private const string MaterialVersionMetadataKey = "MaterialVersion";

    public static string DisplayVersion => $"v{Version}";

    public static string Version
    {
        get
        {
            var metadataVersion = typeof(GalleryVersionInfo).Assembly
                                                            .GetCustomAttributes<AssemblyMetadataAttribute>()
                                                            .FirstOrDefault(attribute =>
                                                                attribute.Key == MaterialVersionMetadataKey)
                                                            ?.Value;
            if (!string.IsNullOrWhiteSpace(metadataVersion))
            {
                return metadataVersion;
            }

            return typeof(GalleryVersionInfo).Assembly.GetName().Version?.ToString(3) ?? string.Empty;
        }
    }
}
