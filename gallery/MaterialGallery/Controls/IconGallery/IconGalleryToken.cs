using AtomUI.Theme.TokenSystem;
using Avalonia;

namespace MaterialGallery.Controls;

[ControlDesignToken]
internal class IconGalleryToken : AbstractControlDesignToken
{
    public const string ID = "IconGallery";
    
    public Thickness SearchInputMargin { get; set; }
    public double IconSize { get; set; }
    public double InfoItemSize { get; set; }

    public IconGalleryToken()
        : base(ID)
    {
    }
    
    public override void CalculateTokenValues()
    {
        base.CalculateTokenValues();
        SearchInputMargin = new Thickness(0, SharedToken.UniformlyMarginXS, SharedToken.UniformlyMarginXS, SharedToken.UniformlyMarginXS);
        IconSize = 48;
        InfoItemSize = 150;
    }
}