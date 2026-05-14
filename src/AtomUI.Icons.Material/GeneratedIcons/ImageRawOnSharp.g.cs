// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageRawOnSharp : MaterialIcon
{
    public ImageRawOnSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 9, 18.48, 6);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1695906432748537, 0, 0, 1.1695906432748537, -2.0350877192982448, -2.0350877192982448);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6.5,9H3v6h1.5v-2h1.1l0.9,2H8l-0.9-2.1C7.6,12.6,8,12.1,8,11.5v-1C8,9.7,7.3,9,6.5,9z M6.5,11.5h-2v-1h2V11.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M10.25,9l-1.5,6h1.5l0.38-1.5h1.75l0.37,1.5h1.5l-1.5-6H10.25z M11,12l0.25-1h0.5L12,12H11z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(19.98, 9),new Avalonia.Point(19.24, 12),new Avalonia.Point(18.5, 9),new Avalonia.Point(16.98, 9),new Avalonia.Point(16.24, 12),new Avalonia.Point(15.5, 9),new Avalonia.Point(14, 9),new Avalonia.Point(15.5, 15),new Avalonia.Point(16.98, 15),new Avalonia.Point(17.74, 11.96),new Avalonia.Point(18.5, 15),new Avalonia.Point(19.98, 15),new Avalonia.Point(21.48, 9)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

