using AtomUI.Theme;
using AtomUI.Theme.TokenSystem;
using MaterialGallery.Controls.DesignTokens;

namespace MaterialGallery.Controls;

[ControlDesignToken]
internal class NavigationToken : AbstractControlDesignToken
{
    /// <summary>
    /// 默认宽度
    /// </summary>
    public double PanelWidth { get; set; }
    
    public const string ID = "Navigation";
    public static readonly ControlTokenResourceScopeProvider ScopeProvider = new(ID);

    public NavigationToken()
        : base(ID)
    {
    }
    
    public override void CalculateTokenValues(bool isDarkMode)
    {
        base.CalculateTokenValues(isDarkMode);
        PanelWidth = 200;
    }

    protected override Type GetTokenKindType() => typeof(NavigationTokenKind);
}
