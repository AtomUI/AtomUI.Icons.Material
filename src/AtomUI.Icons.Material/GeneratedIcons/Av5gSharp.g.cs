// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class Av5gSharp : MaterialIcon
{
    public Av5gSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 7, 18, 10);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(17, 13),new Avalonia.Point(19, 13),new Avalonia.Point(19, 15),new Avalonia.Point(14, 15),new Avalonia.Point(14, 9),new Avalonia.Point(21, 9),new Avalonia.Point(21, 7),new Avalonia.Point(12, 7),new Avalonia.Point(12, 17),new Avalonia.Point(21, 17),new Avalonia.Point(21, 11),new Avalonia.Point(17, 11)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(3, 13),new Avalonia.Point(8, 13),new Avalonia.Point(8, 15),new Avalonia.Point(3, 15),new Avalonia.Point(3, 17),new Avalonia.Point(10, 17),new Avalonia.Point(10, 11),new Avalonia.Point(5, 11),new Avalonia.Point(5, 9),new Avalonia.Point(10, 9),new Avalonia.Point(10, 7),new Avalonia.Point(3, 7)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

