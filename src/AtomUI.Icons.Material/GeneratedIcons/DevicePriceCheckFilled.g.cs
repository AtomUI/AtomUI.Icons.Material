// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DevicePriceCheckFilled : Icon
{
    public DevicePriceCheckFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,13V9c0-0.55-0.45-1-1-1H7V6h5V4H9.5V3h-2v1H6C5.45,4,5,4.45,5,5v4c0,0.55,0.45,1,1,1h4v2H5v2h2.5v1h2v-1H11 C11.55,14,12,13.55,12,13z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(19.59, 12.52),new Point(13.93, 18.17),new Point(11.1, 15.34),new Point(9.69, 16.76),new Point(13.93, 21),new Point(21, 13.93)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

