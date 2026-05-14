// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class Av9kTwoTone : MaterialIcon
{
    public Av9kTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5,19h14V5H5V19z M13,9h1.5v2.25L16.25,9H18l-2.25,3L18,15h-1.75l-1.75-2.25V15H13V9z M6.5,13.5h3v-1h-2 c-0.55,0-1-0.45-1-1V10c0-0.55,0.45-1,1-1H10c0.55,0,1,0.45,1,1v4c0,0.55-0.45,1-1,1H6.5V13.5z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(8, 10, 1.5, 1.5),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M11,14v-4c0-0.55-0.45-1-1-1H7.5c-0.55,0-1,0.45-1,1v1.5c0,0.55,0.45,1,1,1h2v1h-3V15H10C10.55,15,11,14.55,11,14z M9.5,11.5H8V10h1.5V11.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,19H5V5h14V19z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(14.5, 12.75),new Avalonia.Point(16.25, 15),new Avalonia.Point(18, 15),new Avalonia.Point(15.75, 12),new Avalonia.Point(18, 9),new Avalonia.Point(16.25, 9),new Avalonia.Point(14.5, 11.25),new Avalonia.Point(14.5, 9),new Avalonia.Point(13, 9),new Avalonia.Point(13, 15),new Avalonia.Point(14.5, 15)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

