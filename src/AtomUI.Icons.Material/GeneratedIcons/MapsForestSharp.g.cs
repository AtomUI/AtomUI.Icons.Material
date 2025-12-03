// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsForestSharp : Icon
{
    public MapsForestSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(16, 12),new Point(9, 2),new Point(2, 12),new Point(3.86, 12),new Point(0, 18),new Point(7, 18),new Point(7, 22),new Point(11, 22),new Point(11, 18),new Point(18, 18),new Point(14.14, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(20.14, 12),new Point(22, 12),new Point(15, 2),new Point(12.61, 5.41),new Point(17.92, 13),new Point(16, 13),new Point(15.97, 13),new Point(19.19, 18),new Point(24, 18)]
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(13, 19, 4, 3),
            RadiusX = 0,
            RadiusY = 0,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

