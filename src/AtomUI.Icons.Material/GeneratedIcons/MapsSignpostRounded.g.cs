// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsSignpostRounded : MaterialIcon
{
    public MapsSignpostRounded()
    {
        IconTheme = IconThemeType.Rounded;
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
            Points = [new Avalonia.Point(13, 10),new Avalonia.Point(18, 10),new Avalonia.Point(21, 7),new Avalonia.Point(18, 4),new Avalonia.Point(13, 4),new Avalonia.Point(13, 2),new Avalonia.Point(11, 2),new Avalonia.Point(11, 4),new Avalonia.Point(4, 4),new Avalonia.Point(4, 10),new Avalonia.Point(11, 10),new Avalonia.Point(11, 12),new Avalonia.Point(6, 12),new Avalonia.Point(3, 15),new Avalonia.Point(6, 18),new Avalonia.Point(11, 18),new Avalonia.Point(11, 22),new Avalonia.Point(13, 22),new Avalonia.Point(13, 18),new Avalonia.Point(20, 18),new Avalonia.Point(20, 12),new Avalonia.Point(13, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

