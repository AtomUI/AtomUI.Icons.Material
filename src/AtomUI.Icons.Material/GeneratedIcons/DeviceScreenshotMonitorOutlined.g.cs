// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceScreenshotMonitorOutlined : Icon
{
    public DeviceScreenshotMonitorOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,3H4C2.89,3,2,3.89,2,5v12c0,1.1,0.89,2,2,2h4v2h8v-2h4c1.1,0,2-0.9,2-2V5C22,3.89,21.1,3,20,3z M20,17H4V5h16V17z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(6.5, 7.5),new Point(9, 7.5),new Point(9, 6),new Point(5, 6),new Point(5, 10),new Point(6.5, 10)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(19, 12),new Point(17.5, 12),new Point(17.5, 14.5),new Point(15, 14.5),new Point(15, 16),new Point(19, 16)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

