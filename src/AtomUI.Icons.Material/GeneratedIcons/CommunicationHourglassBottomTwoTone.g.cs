// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class CommunicationHourglassBottomTwoTone : Icon
{
    public CommunicationHourglassBottomTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(16, 16.5),new Point(12, 12.5),new Point(8, 16.5),new Point(8, 20),new Point(16, 20)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(16, 16.5),new Point(12, 12.5),new Point(8, 16.5),new Point(8, 20),new Point(16, 20)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M6,22h12v-6l-4-4l3.99-4.01L18,2H6l0.01,5.99L10,12l-4,3.99V22z M8,7.5V4h8v3.5l-4,4L8,7.5z M8,16.5l4-4l4,4V20H8V16.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

