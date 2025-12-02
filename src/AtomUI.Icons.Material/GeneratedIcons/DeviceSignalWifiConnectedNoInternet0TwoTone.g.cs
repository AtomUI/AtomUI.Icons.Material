// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceSignalWifiConnectedNoInternet0TwoTone : Icon
{
    public DeviceSignalWifiConnectedNoInternet0TwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M24,8.98C20.93,5.9,16.69,4,12,4C7.31,4,3.07,5.9,0,8.98L12,21v-9h8.99L24,8.98z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(19.59, 14),new Point(17.5, 16.09),new Point(17.2, 15.79),new Point(15.41, 14),new Point(14, 15.41),new Point(15.79, 17.2),new Point(16.09, 17.5),new Point(14, 19.59),new Point(15.41, 21),new Point(17.5, 18.92),new Point(19.59, 21),new Point(21, 19.59),new Point(18.92, 17.5),new Point(21, 15.41)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

