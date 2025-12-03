// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionSwipeDownAltTwoTone : Icon
{
    public ActionSwipeDownAltTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Center = new Point(12, 9),
            Radius = 3
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M13,13.9c2.28-0.46,4-2.48,4-4.9c0-2.76-2.24-5-5-5S7,6.24,7,9c0,2.42,1.72,4.44,4,4.9v4.27l-1.59-1.59L8,18l4,4l4-4 l-1.41-1.41L13,18.17V13.9z M15,9c0,1.66-1.34,3-3,3s-3-1.34-3-3s1.34-3,3-3S15,7.34,15,9z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

