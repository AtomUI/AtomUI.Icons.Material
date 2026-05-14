// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsRemoveRoadFilled : MaterialIcon
{
    public MapsRemoveRoadFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 4, 18.5, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2307692307692308, 0, 0, 1.2307692307692308, -2.7692307692307701, -2.7692307692307701);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(18, 4, 2, 9),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(4, 4, 2, 16),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(11, 4, 2, 4),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(11, 10, 2, 4),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(11, 16, 2, 4),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(22.5, 16.41),new Avalonia.Point(21.09, 15),new Avalonia.Point(19, 17.09),new Avalonia.Point(16.91, 15),new Avalonia.Point(15.5, 16.41),new Avalonia.Point(17.59, 18.5),new Avalonia.Point(15.5, 20.59),new Avalonia.Point(16.91, 22),new Avalonia.Point(19, 19.91),new Avalonia.Point(21.09, 22),new Avalonia.Point(22.5, 20.59),new Avalonia.Point(20.41, 18.5)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

