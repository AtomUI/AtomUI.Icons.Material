// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class SocialMan4Rounded : Icon
{
    public SocialMan4Rounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13.75,7h-3.5C9.04,7,8.11,8.07,8.27,9.26L9.82,20.7c0.1,0.74,0.74,1.3,1.49,1.3h1.38c0.75,0,1.39-0.55,1.49-1.3 l1.56-11.44C15.89,8.07,14.96,7,13.75,7z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Point(12, 4),
            Radius = 2
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

