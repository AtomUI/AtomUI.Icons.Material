// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class Av4kPlusOutlined : MaterialIcon
{
    public Av4kPlusOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,11.5h-1.5V10h-1v1.5H15v1h1.5 V14h1v-1.5H19V19H5V5h14V11.5z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(8.5, 15),new Avalonia.Point(10, 15),new Avalonia.Point(10, 13.5),new Avalonia.Point(11, 13.5),new Avalonia.Point(11, 12),new Avalonia.Point(10, 12),new Avalonia.Point(10, 9),new Avalonia.Point(8.5, 9),new Avalonia.Point(8.5, 12),new Avalonia.Point(7, 12),new Avalonia.Point(7, 9),new Avalonia.Point(5.5, 9),new Avalonia.Point(5.5, 13.5),new Avalonia.Point(8.5, 13.5)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(13, 12.75),new Avalonia.Point(14.75, 15),new Avalonia.Point(16.5, 15),new Avalonia.Point(14.25, 12),new Avalonia.Point(16.5, 9),new Avalonia.Point(14.75, 9),new Avalonia.Point(13, 11.25),new Avalonia.Point(13, 9),new Avalonia.Point(11.5, 9),new Avalonia.Point(11.5, 15),new Avalonia.Point(13, 15)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

