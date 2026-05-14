// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageMicExternalOffSharp : MaterialIcon
{
    public ImageMicExternalOffSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.68999999999999995, 2, 21.210000000000001, 21.32);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0300429184549356, 0, 0, 1.0300429184549356, -0.36051502145922676, -0.36051502145922676);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M10,5c0-1.66-1.34-3-3-3C6.38,2,5.81,2.19,5.33,2.5l4.15,4.15C9.8,6.18,10,5.61,10,5z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(14, 4),new Avalonia.Point(18, 4),new Avalonia.Point(18, 15.17),new Avalonia.Point(20, 17.17),new Avalonia.Point(20, 2),new Avalonia.Point(12, 2),new Avalonia.Point(12, 9.17),new Avalonia.Point(14, 11.17)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.1,2.1L0.69,3.51L5.17,8H4l1,10h1c0,2.21,0,4,0,4h8v-5.17l6.49,6.49l1.41-1.41L2.1,2.1z M12,20H8v-2h1l0.56-5.61 L12,14.83V20z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

