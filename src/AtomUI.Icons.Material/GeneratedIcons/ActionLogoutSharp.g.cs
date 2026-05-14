// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionLogoutSharp : MaterialIcon
{
    public ActionLogoutSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(5, 5),new Avalonia.Point(12, 5),new Avalonia.Point(12, 3),new Avalonia.Point(3, 3),new Avalonia.Point(3, 21),new Avalonia.Point(12, 21),new Avalonia.Point(12, 19),new Avalonia.Point(5, 19)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(21, 12),new Avalonia.Point(17, 8),new Avalonia.Point(17, 11),new Avalonia.Point(9, 11),new Avalonia.Point(9, 13),new Avalonia.Point(17, 13),new Avalonia.Point(17, 16)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

