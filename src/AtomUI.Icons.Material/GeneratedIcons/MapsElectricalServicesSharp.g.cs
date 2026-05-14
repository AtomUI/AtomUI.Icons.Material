// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsElectricalServicesSharp : MaterialIcon
{
    public MapsElectricalServicesSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 4, 18, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(18, 13, 3, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(12, 12),new Avalonia.Point(12, 14),new Avalonia.Point(10, 14),new Avalonia.Point(10, 18),new Avalonia.Point(12, 18),new Avalonia.Point(12, 20),new Avalonia.Point(17, 20),new Avalonia.Point(17, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(5, 11),new Avalonia.Point(12, 11),new Avalonia.Point(12, 4),new Avalonia.Point(4, 4),new Avalonia.Point(4, 6),new Avalonia.Point(10, 6),new Avalonia.Point(10, 9),new Avalonia.Point(3, 9),new Avalonia.Point(3, 17),new Avalonia.Point(9, 17),new Avalonia.Point(9, 15),new Avalonia.Point(5, 15)]
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(18, 17, 3, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

