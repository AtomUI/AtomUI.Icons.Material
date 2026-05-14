// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsTurnSlightLeftSharp : MaterialIcon
{
    public MapsTurnSlightLeftSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 4, 9, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(11.66, 6),new Avalonia.Point(11.66, 4),new Avalonia.Point(6, 4),new Avalonia.Point(6, 9.66),new Avalonia.Point(8, 9.66),new Avalonia.Point(8, 7.41),new Avalonia.Point(13, 12.41),new Avalonia.Point(13, 20),new Avalonia.Point(15, 20),new Avalonia.Point(15, 11.59),new Avalonia.Point(9.41, 6)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

