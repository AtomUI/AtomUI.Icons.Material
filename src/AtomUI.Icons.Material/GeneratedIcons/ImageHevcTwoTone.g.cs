// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageHevcTwoTone : MaterialIcon
{
    public ImageHevcTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 9, 18, 6);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(5.5, 11),new Avalonia.Point(4.5, 11),new Avalonia.Point(4.5, 9),new Avalonia.Point(3, 9),new Avalonia.Point(3, 15),new Avalonia.Point(4.5, 15),new Avalonia.Point(4.5, 12.5),new Avalonia.Point(5.5, 12.5),new Avalonia.Point(5.5, 15),new Avalonia.Point(7, 15),new Avalonia.Point(7, 9),new Avalonia.Point(5.5, 9)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M21,11v-1c0-0.55-0.45-1-1-1h-2c-0.55,0-1,0.45-1,1v4c0,0.55,0.45,1,1,1h2c0.55,0,1-0.45,1-1v-1h-1.5v0.5h-1v-3h1V11H21z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(14.25, 13.5),new Avalonia.Point(13.5, 9),new Avalonia.Point(12, 9),new Avalonia.Point(13, 15),new Avalonia.Point(15.5, 15),new Avalonia.Point(16.5, 9),new Avalonia.Point(15, 9)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(8, 9),new Avalonia.Point(8, 15),new Avalonia.Point(11.5, 15),new Avalonia.Point(11.5, 13.5),new Avalonia.Point(9.5, 13.5),new Avalonia.Point(9.5, 12.5),new Avalonia.Point(11.5, 12.5),new Avalonia.Point(11.5, 11),new Avalonia.Point(9.5, 11),new Avalonia.Point(9.5, 10.5),new Avalonia.Point(11.5, 10.5),new Avalonia.Point(11.5, 9)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

