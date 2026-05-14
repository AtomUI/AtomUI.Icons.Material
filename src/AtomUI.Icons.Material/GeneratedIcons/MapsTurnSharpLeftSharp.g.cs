// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsTurnSharpLeftSharp : MaterialIcon
{
    public MapsTurnSharpLeftSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 15, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6, 6.83),new Avalonia.Point(4.41, 8.41),new Avalonia.Point(3, 7),new Avalonia.Point(7, 3),new Avalonia.Point(11, 7),new Avalonia.Point(9.59, 8.41),new Avalonia.Point(8, 6.83),new Avalonia.Point(8, 13),new Avalonia.Point(18, 13),new Avalonia.Point(18, 21),new Avalonia.Point(16, 21),new Avalonia.Point(16, 15),new Avalonia.Point(6, 15)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

