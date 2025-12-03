using AtomUI.Controls;

namespace MaterialGallery.Models;

public class IconInfo
{
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public IconThemeType ThemeType { get; set; }
    public Icon? Icon { get; set; }
    public Type? IconType { get; set; }
    public Func<Icon>? Creator { get; set; }
}