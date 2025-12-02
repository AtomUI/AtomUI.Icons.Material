// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceSimCardDownloadTwoTone : Icon
{
    public DeviceSimCardDownloadTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6,8.83V20h12V4h-7.17L6,8.83z M11,9.02L13,9v4h3l-4,4l-4-4h3V9.02z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M18,2h-8L4,8v12c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2V4C20,2.9,19.1,2,18,2z M18,20H6V8.83L10.83,4H18V20z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(12, 17),new Point(16, 13),new Point(13, 13),new Point(13, 9),new Point(11, 9.02),new Point(11, 13),new Point(8, 13)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

