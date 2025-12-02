// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class PlacesCottageTwoTone : Icon
{
    public PlacesCottageTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(18, 19),new Point(13, 19),new Point(13, 15),new Point(11, 15),new Point(11, 19),new Point(6, 19),new Point(6, 10.1),new Point(12, 5.52),new Point(18, 10.1)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M12,3L6,7.58V6H4v3.11L1,11.4l1.21,1.59L4,11.62V21h16v-9.38l1.79,1.36L23,11.4L12,3z M18,19h-5v-4h-2v4H6v-8.9l6-4.58 l6,4.58V19z M10,1c0,1.66-1.34,3-3,3C6.45,4,6,4.45,6,5H4c0-1.66,1.34-3,3-3c0.55,0,1-0.45,1-1H10z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

