// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DevicePunchClockSharp : Icon
{
    public DevicePunchClockSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21,6h-3V1H6v5H3v16h18V6z M8,3h8v3H8V3z M12,19c-2.76,0-5-2.24-5-5s2.24-5,5-5c2.76,0,5,2.24,5,5S14.76,19,12,19z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(12.5, 11.5),new Point(11.5, 11.5),new Point(11.5, 14.21),new Point(13.14, 15.85),new Point(13.85, 15.14),new Point(12.5, 13.79)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

