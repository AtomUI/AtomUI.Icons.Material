// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsParkSharp : MaterialIcon
{
    public MapsParkSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.1000000000000001, 2, 17.899999999999999, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(17, 12),new Avalonia.Point(19, 12),new Avalonia.Point(12, 2),new Avalonia.Point(5.05, 12),new Avalonia.Point(7, 12),new Avalonia.Point(3.1, 18),new Avalonia.Point(10.02, 18),new Avalonia.Point(10.02, 22),new Avalonia.Point(13.98, 22),new Avalonia.Point(13.98, 18),new Avalonia.Point(21, 18)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

