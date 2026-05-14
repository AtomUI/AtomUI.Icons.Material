// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsDiamondFilled : MaterialIcon
{
    public MapsDiamondFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.3799999999999999, 3, 19.240000000000002, 17.100000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1100832562442182, 0, 0, 1.1100832562442182, -1.3209990749306186, -1.3209990749306186);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(12.16, 3),new Avalonia.Point(11.84, 3),new Avalonia.Point(9.21, 8.25),new Avalonia.Point(14.79, 8.25)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(16.46, 8.25),new Avalonia.Point(21.62, 8.25),new Avalonia.Point(19, 3),new Avalonia.Point(13.84, 3)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(21.38, 9.75),new Avalonia.Point(12.75, 9.75),new Avalonia.Point(12.75, 20.1)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(11.25, 20.1),new Avalonia.Point(11.25, 9.75),new Avalonia.Point(2.62, 9.75)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(7.54, 8.25),new Avalonia.Point(10.16, 3),new Avalonia.Point(5, 3),new Avalonia.Point(2.38, 8.25)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

