// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionEditOffRounded : MaterialIcon
{
    public ActionEditOffRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.71, 2.8999999999999999, 19.390000000000001, 19.390000000000004);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0767160161507405, 0, 0, 1.0767160161507405, -0.92059219380888635, -0.92059219380888635);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.1,3.51L2.1,3.51c-0.39,0.39-0.39,1.02,0,1.41l6.61,6.61L3.15,17.1C3.05,17.2,3,17.32,3,17.46v3.04 C3,20.78,3.22,21,3.5,21h3.04c0.13,0,0.26-0.05,0.35-0.15l5.56-5.56l6.61,6.61c0.39,0.39,1.02,0.39,1.41,0l0,0 c0.39-0.39,0.39-1.02,0-1.41L3.52,3.51C3.12,3.12,2.49,3.12,2.1,3.51z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20.71,7.04c0.39-0.39,0.39-1.02,0-1.41l-2.34-2.34c-0.39-0.39-1.02-0.39-1.41,0l-1.83,1.83l3.75,3.75L20.71,7.04z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(12.89, 6.67, 3.56, 5.3),
            RadiusX = 0,
            RadiusY = 0,
            Transform = new Matrix(0.70709999999999995, -0.70709999999999995, 0.70709999999999995, 0.70709999999999995, -2.2957000000000001, 13.107900000000001)
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

