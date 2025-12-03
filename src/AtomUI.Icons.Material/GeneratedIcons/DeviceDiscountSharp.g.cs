// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceDiscountSharp : Icon
{
    public DeviceDiscountSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(12.79, 21),new Point(3, 11.21),new Point(3, 14.04),new Point(12.79, 23.83),new Point(21.83, 14.79),new Point(20.41, 13.38)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M3,9.04l9.79,9.79l9.04-9.04L12.04,0H3V9.04z M7.25,3C7.94,3,8.5,3.56,8.5,4.25S7.94,5.5,7.25,5.5S6,4.94,6,4.25 S6.56,3,7.25,3z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

