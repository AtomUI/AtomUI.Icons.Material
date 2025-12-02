// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class Image19mpSharp : Icon
{
    public Image19mpSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(13.5, 6.5, 1.5, 1.5),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(15, 14, 1.5, 1.5),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M3,3v18h18V3H3z M12,10h3V9h-3V5.5h4.5v6H12V10z M7,5.5h3v6H8.5V7H7V5.5z M12.5,18.5H11V14h-1v3H8.5v-3h-1v4.5H6v-6h6.5 V18.5z M18,17h-3v1.5h-1.5v-6H18V17z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

