// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsTurnRightSharp : MaterialIcon
{
    public MapsTurnRightSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(7, 6, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.6000000000000001, 0, 0, 1.6000000000000001, -7.2000000000000028, -7.2000000000000028);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(17.17, 11),new Avalonia.Point(15.59, 12.59),new Avalonia.Point(17, 14),new Avalonia.Point(21, 10),new Avalonia.Point(17, 6),new Avalonia.Point(15.59, 7.41),new Avalonia.Point(17.17, 9),new Avalonia.Point(7, 9),new Avalonia.Point(7, 20),new Avalonia.Point(9, 20),new Avalonia.Point(9, 11)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

