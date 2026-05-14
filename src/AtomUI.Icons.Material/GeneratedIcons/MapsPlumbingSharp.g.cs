// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsPlumbingSharp : MaterialIcon
{
    public MapsPlumbingSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.4199999999999999, 1.3999999999999995, 17.449999999999996, 21.210000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0624169986719787, 0, 0, 1.0624169986719787, -0.74900398406374435, -0.74900398406374435);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M16.16,5.64l3.54,3.54c1.17-1.17,1.17-3.07,0-4.24l-3.54-3.54l-4.24,4.24l2.12,2.12L16.16,5.64z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(5.17, 10.5, 5, 3),
            RadiusX = 0,
            RadiusY = 0,
            Transform = new Matrix(0.70709999999999995, -0.70709999999999995, 0.70709999999999995, 0.70709999999999995, -6.2382999999999997, 8.9392999999999994)
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15.45,7.76l-1.41,1.41L9.79,4.93L7.67,7.05l4.24,4.24l-8.49,8.49l2.83,2.83L16.86,12l0.71,0.71l1.41-1.41L15.45,7.76z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

