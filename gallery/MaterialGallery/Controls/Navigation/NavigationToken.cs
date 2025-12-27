using AtomUI.Theme.TokenSystem;

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
        : base(ID)
    {
    }
    
    public override void CalculateTokenValues(bool isDarkMode)
    {
        base.CalculateTokenValues(isDarkMode);
        PanelWidth = 200;
    }
}