// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorPolylineSharp : MaterialIcon
{
    public EditorPolylineSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 2, 18, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(15, 16),new Avalonia.Point(15, 17.26),new Avalonia.Point(9, 14.26),new Avalonia.Point(9, 11.09),new Avalonia.Point(11.7, 8),new Avalonia.Point(16, 8),new Avalonia.Point(16, 2),new Avalonia.Point(10, 2),new Avalonia.Point(10, 6.9),new Avalonia.Point(7.3, 10),new Avalonia.Point(3, 10),new Avalonia.Point(3, 16),new Avalonia.Point(8, 16),new Avalonia.Point(15, 19.5),new Avalonia.Point(15, 22),new Avalonia.Point(21, 22),new Avalonia.Point(21, 16)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

