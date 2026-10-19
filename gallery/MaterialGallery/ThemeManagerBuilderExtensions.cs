using AtomUI;
using AtomUI.Generated.MaterialGallery;

namespace MaterialGallery;

public static class ThemeManagerBuilderExtensions
{
    public static IAtomUIBuilder UseGalleryControls(this IAtomUIBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        return GeneratedControlPackageRegistration.Definition.Register(builder);
    }
}
