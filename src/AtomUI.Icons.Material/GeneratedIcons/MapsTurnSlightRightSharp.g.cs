// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsTurnSlightRightSharp : MaterialIcon
{
    public MapsTurnSlightRightSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(9, 4, 9, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(12.34, 6),new Avalonia.Point(12.34, 4),new Avalonia.Point(18, 4),new Avalonia.Point(18, 9.66),new Avalonia.Point(16, 9.66),new Avalonia.Point(16, 7.41),new Avalonia.Point(11, 12.41),new Avalonia.Point(11, 20),new Avalonia.Point(9, 20),new Avalonia.Point(9, 11.59),new Avalonia.Point(14.59, 6)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

