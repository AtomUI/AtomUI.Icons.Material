// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsForestFilled : MaterialIcon
{
    public MapsForestFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 2, 24, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(16, 12),new Avalonia.Point(9, 2),new Avalonia.Point(2, 12),new Avalonia.Point(3.86, 12),new Avalonia.Point(0, 18),new Avalonia.Point(7, 18),new Avalonia.Point(7, 22),new Avalonia.Point(11, 22),new Avalonia.Point(11, 18),new Avalonia.Point(18, 18),new Avalonia.Point(14.14, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(20.14, 12),new Avalonia.Point(22, 12),new Avalonia.Point(15, 2),new Avalonia.Point(12.61, 5.41),new Avalonia.Point(17.92, 13),new Avalonia.Point(16, 13),new Avalonia.Point(15.97, 13),new Avalonia.Point(19.19, 18),new Avalonia.Point(24, 18)]
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

