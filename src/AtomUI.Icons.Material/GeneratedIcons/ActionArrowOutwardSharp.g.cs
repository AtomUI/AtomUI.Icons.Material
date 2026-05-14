// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionArrowOutwardSharp : MaterialIcon
{
    public ActionArrowOutwardSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 6, 13, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.263157894736842, 0, 0, 1.263157894736842, -3.1578947368421044, -3.1578947368421044);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6, 6),new Avalonia.Point(6, 8),new Avalonia.Point(14.59, 8),new Avalonia.Point(5, 17.59),new Avalonia.Point(6.41, 19),new Avalonia.Point(16, 9.41),new Avalonia.Point(16, 18),new Avalonia.Point(18, 18),new Avalonia.Point(18, 6)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

