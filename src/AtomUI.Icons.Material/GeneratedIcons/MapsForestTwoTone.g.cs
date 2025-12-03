// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsForestTwoTone : Icon
{
    public MapsForestTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(16.48, 10),new Point(18.16, 10),new Point(15, 5.49),new Point(13.22, 8.03),new Point(16, 12),new Point(14.14, 12),new Point(16.71, 16),new Point(20.34, 16)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(12.16, 10),new Point(9, 5.49),new Point(5.84, 10),new Point(7.52, 10),new Point(3.66, 16),new Point(14.34, 16),new Point(10.48, 10)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20.14,12H22L15,2l-3,4.29L9,2L2,12h1.86L0,18h7v4h4v-4h2v4h4v-4h7L20.14,12z M3.66,16l3.86-6H5.84L9,5.49L12.16,10h-1.68 l3.86,6H3.66z M16.71,16l-2.57-4H16l-2.78-3.97L15,5.49L18.16,10h-1.68l3.86,6H16.71z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

