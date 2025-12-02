// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class SocialDeckOutlined : Icon
{
    public SocialDeckOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M22,9L12,2L2,9h9v13h2V9H22z M12,4.44L15.66,7H8.34L12,4.44z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(4.14, 12),new Point(2.18, 12.37),new Point(3, 16.74),new Point(3, 22),new Point(5, 22),new Point(5.02, 18),new Point(7, 18),new Point(7, 22),new Point(9, 22),new Point(9, 16),new Point(4.9, 16)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(19.1, 16),new Point(15, 16),new Point(15, 22),new Point(17, 22),new Point(17, 18),new Point(18.98, 18),new Point(19, 22),new Point(21, 22),new Point(21, 16.74),new Point(21.82, 12.37),new Point(19.86, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

