// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceFluorescentTwoTone : MaterialIcon
{
    public DeviceFluorescentTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.4921619999999987, 2, 17.007838, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(7, 11, 10, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M5,15h14V9H5V15z M7,11h10v2H7V11z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(11, 2, 2, 3),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(17.62, 5.2, 2.54, 2),
            RadiusX = 0,
            RadiusY = 0,
            Transform = new Matrix(0.7046, -0.70960000000000001, 0.70960000000000001, 0.7046, 1.1814, 15.238099999999999)
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(11, 19, 2, 3),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(17.29, 17.71),new Avalonia.Point(19.08, 19.51),new Avalonia.Point(20.5, 18.09),new Avalonia.Point(18.7, 16.3)]
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(4.1, 4.93, 1.99, 2.53),
            RadiusX = 0,
            RadiusY = 0,
            Transform = new Matrix(0.70709999999999995, -0.70709999999999995, 0.70709999999999995, 0.70709999999999995, -2.8904000000000001, 5.4222000000000001)
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(3.83, 16.89, 2.54, 2),
            RadiusX = 0,
            RadiusY = 0,
            Transform = new Matrix(0.70960000000000001, -0.7046, 0.7046, 0.70960000000000001, -11.126300000000001, 8.7896999999999998)
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

