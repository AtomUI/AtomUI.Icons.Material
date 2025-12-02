// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ImageIncompleteCircleRounded : Icon
{
    public ImageIncompleteCircleRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,12c0,5.52-4.48,10-10,10S2,17.52,2,12c0-2.76,1.12-5.26,2.93-7.07L12,12V2C17.52,2,22,6.48,22,12z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

