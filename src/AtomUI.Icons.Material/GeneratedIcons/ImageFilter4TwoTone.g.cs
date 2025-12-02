// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ImageFilter4TwoTone : Icon
{
    public ImageFilter4TwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21 3H7v14h14V3zm-4 12h-2v-4h-4V5h2v4h2V5h2v10z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M3 23h16v-2H3V5H1v16c0 1.1.9 2 2 2zm4-4h14c1.1 0 2-.9 2-2V3c0-1.1-.9-2-2-2H7c-1.1 0-2 .9-2 2v14c0 1.1.9 2 2 2zM7 3h14v14H7V3zm8 6h-2V5h-2v6h4v4h2V5h-2z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

