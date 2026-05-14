// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorCandlestickChartSharp : MaterialIcon
{
    public EditorCandlestickChartSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 4, 14, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(9, 4),new Avalonia.Point(7, 4),new Avalonia.Point(7, 6),new Avalonia.Point(5, 6),new Avalonia.Point(5, 18),new Avalonia.Point(7, 18),new Avalonia.Point(7, 20),new Avalonia.Point(9, 20),new Avalonia.Point(9, 18),new Avalonia.Point(11, 18),new Avalonia.Point(11, 6),new Avalonia.Point(9, 6)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(19, 8),new Avalonia.Point(17, 8),new Avalonia.Point(17, 4),new Avalonia.Point(15, 4),new Avalonia.Point(15, 8),new Avalonia.Point(13, 8),new Avalonia.Point(13, 15),new Avalonia.Point(15, 15),new Avalonia.Point(15, 20),new Avalonia.Point(17, 20),new Avalonia.Point(17, 15),new Avalonia.Point(19, 15)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

