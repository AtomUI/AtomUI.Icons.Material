using AtomUI.Theme.TokenSystem;
using AtomUI.Theme;

namespace MaterialGallery.Controls.DesignTokens
{
    public enum IconGalleryTokenKind
    {
        IconSize,
        InfoItemSize,
        SearchInputMargin
    }

    public enum NavigationTokenKind
    {
        PanelWidth
    }

    public class IconGalleryTokenResourceExtension : TokenResourceExtension<IconGalleryTokenKind>
    {
        public IconGalleryTokenResourceExtension()
        {
        }

        public IconGalleryTokenResourceExtension(IconGalleryTokenKind kind) : base(kind)
        {
        }
    }

    public class NavigationTokenResourceExtension : TokenResourceExtension<NavigationTokenKind>
    {
        public NavigationTokenResourceExtension()
        {
        }

        public NavigationTokenResourceExtension(NavigationTokenKind kind) : base(kind)
        {
        }
    }
}