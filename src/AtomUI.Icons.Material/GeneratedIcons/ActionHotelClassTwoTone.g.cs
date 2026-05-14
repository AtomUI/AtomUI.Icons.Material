// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionHotelClassTwoTone : MaterialIcon
{
    public ActionHotelClassTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 2, 22.68, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0416666666666667, 0, 0, 1.0416666666666667, -0.5, -0.5);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(11, 8.89),new Avalonia.Point(11.94, 12),new Avalonia.Point(14.76, 12),new Avalonia.Point(12.49, 13.62),new Avalonia.Point(13.42, 16.63),new Avalonia.Point(11, 14.79),new Avalonia.Point(8.58, 16.63),new Avalonia.Point(9.51, 13.62),new Avalonia.Point(7.24, 12),new Avalonia.Point(10.06, 12)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("m11 8.89.94 3.11h2.82l-2.27 1.62.93 3.01L11 14.79l-2.42 1.84.93-3.01L7.24 12h2.82L11 8.89zM8.58 10H1l6.17 4.41L4.83 22 11 17.31 17.18 22l-2.35-7.59L21 10h-7.58L11 2l-2.42 8zm12.78 12-1.86-6.01L23.68 13h-3.44l-3.08 2.2 1.46 4.72L21.36 22zM17 8l-1.82-6-1.04 3.45.77 2.55H17z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

