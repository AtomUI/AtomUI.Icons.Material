// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionQuickreplySharp : MaterialIcon
{
    public ActionQuickreplySharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 2, 20.5, 21);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(22, 2),new Avalonia.Point(2, 2),new Avalonia.Point(2, 22),new Avalonia.Point(6, 18),new Avalonia.Point(15, 18),new Avalonia.Point(15, 10),new Avalonia.Point(22, 10)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(22.5, 16),new Avalonia.Point(20.3, 16),new Avalonia.Point(22, 12),new Avalonia.Point(17, 12),new Avalonia.Point(17, 18),new Avalonia.Point(19, 18),new Avalonia.Point(19, 23)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

