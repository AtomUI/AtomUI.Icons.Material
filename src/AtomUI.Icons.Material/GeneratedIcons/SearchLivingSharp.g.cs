// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SearchLivingSharp : MaterialIcon
{
    public SearchLivingSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 2, 20, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(15.5, 12),new Avalonia.Point(15.5, 14.5),new Avalonia.Point(8.5, 14.5),new Avalonia.Point(8.5, 12),new Avalonia.Point(7.52, 12),new Avalonia.Point(6.5, 12),new Avalonia.Point(6.5, 16.5),new Avalonia.Point(17.5, 16.5),new Avalonia.Point(17.5, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(10, 10),new Avalonia.Point(10, 13),new Avalonia.Point(14, 13),new Avalonia.Point(14, 10),new Avalonia.Point(16.25, 9.99),new Avalonia.Point(16.25, 7.5),new Avalonia.Point(7.75, 7.5),new Avalonia.Point(7.75, 9.99)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,2H2v20h20V2z M19,9.99V18H5v-8l1.25-0.01V6h11.5v3.99H19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

