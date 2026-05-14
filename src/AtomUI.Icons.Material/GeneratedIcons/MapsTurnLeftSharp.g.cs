// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsTurnLeftSharp : MaterialIcon
{
    public MapsTurnLeftSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 6, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6.83, 11),new Avalonia.Point(8.41, 12.59),new Avalonia.Point(7, 14),new Avalonia.Point(3, 10),new Avalonia.Point(7, 6),new Avalonia.Point(8.41, 7.41),new Avalonia.Point(6.83, 9),new Avalonia.Point(17, 9),new Avalonia.Point(17, 20),new Avalonia.Point(15, 20),new Avalonia.Point(15, 11)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

