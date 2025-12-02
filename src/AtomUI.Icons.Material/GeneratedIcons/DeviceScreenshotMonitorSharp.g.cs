// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceScreenshotMonitorSharp : Icon
{
    public DeviceScreenshotMonitorSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,3H2v16h6v2h8v-2h6V3z M20,17H4V5h16V17z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(6.5, 7.5),new Point(9, 7.5),new Point(9, 6),new Point(5, 6),new Point(5, 10),new Point(6.5, 10)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(19, 12),new Point(17.5, 12),new Point(17.5, 14.5),new Point(15, 14.5),new Point(15, 16),new Point(19, 16)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

