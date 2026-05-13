using AtomUI.Theme;
using AtomUI.Theme.TokenSystem;
using Avalonia;
using MaterialGallery.Controls.DesignTokens;

namespace MaterialGallery.Controls;

[ControlDesignToken]
internal class IconGalleryToken : AbstractControlDesignToken
{
    public const string ID = "IconGallery";
    public static readonly ControlTokenResourceScopeProvider ScopeProvider = new(ID);
    
    public Thickness SearchInputMargin { get; set; }
    public double IconSize { get; set; }
    public double InfoItemSize { get; set; }

    public IconGalleryToken()
        : base(ID)
    {
    }
    
    public override void CalculateTokenValues(bool isDarkMode)
    {
        base.CalculateTokenValues(isDarkMode);
        SearchInputMargin = new Thickness(0, SharedToken.UniformlyMarginXS, SharedToken.UniformlyMarginXS, SharedToken.UniformlyMarginXS);
        IconSize = 48;
        InfoItemSize = 150;
    }

    protected override Type GetTokenKindType() => typeof(IconGalleryTokenKind);
}
