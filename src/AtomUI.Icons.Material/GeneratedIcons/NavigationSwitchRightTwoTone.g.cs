// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class NavigationSwitchRightTwoTone : Icon
{
    public NavigationSwitchRightTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolylineDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(15.5, 15.38),new Point(15.5, 8.62),new Point(18.88, 12),new Point(15.5, 15.38)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M15.5,15.38V8.62L18.88,12L15.5,15.38 M14,19l7-7l-7-7V19L14,19z M10,19V5l-7,7L10,19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

