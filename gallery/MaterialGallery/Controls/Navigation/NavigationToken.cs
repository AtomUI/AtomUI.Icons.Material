using AtomUI.Theme.DesignTokens;
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

    public NavigationToken()
    {
    }
    
    public override void CalculateTokenValues(bool isDarkMode)
    {
        base.CalculateTokenValues(isDarkMode);
        PanelWidth = 200;
    }
}
