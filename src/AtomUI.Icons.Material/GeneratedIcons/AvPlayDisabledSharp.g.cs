// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class AvPlayDisabledSharp : MaterialIcon
{
    public AvPlayDisabledSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.3899999999999999, 2.8100000000000001, 19.800000000000001, 19.800000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0614772224679345, 0, 0, 1.0614772224679345, -0.73772666961521338, -0.73772666961521338);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(16.45, 13.62),new Avalonia.Point(19, 12),new Avalonia.Point(8, 5),new Avalonia.Point(8, 5.17)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(2.81, 2.81),new Avalonia.Point(1.39, 4.22),new Avalonia.Point(8, 10.83),new Avalonia.Point(8, 19),new Avalonia.Point(12.99, 15.82),new Avalonia.Point(19.78, 22.61),new Avalonia.Point(21.19, 21.19)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

