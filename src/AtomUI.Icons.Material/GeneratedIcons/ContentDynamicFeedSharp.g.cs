// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ContentDynamicFeedSharp : MaterialIcon
{
    public ContentDynamicFeedSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 3, 20, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(8, 8),new Avalonia.Point(6, 8),new Avalonia.Point(6, 17),new Avalonia.Point(17, 17),new Avalonia.Point(17, 15),new Avalonia.Point(8, 15)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,3H10v10h12V3z M20,11h-8V7h8V11z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(4, 12),new Avalonia.Point(2, 12),new Avalonia.Point(2, 21),new Avalonia.Point(13, 21),new Avalonia.Point(13, 19),new Avalonia.Point(4, 19)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(8, 8),new Avalonia.Point(6, 8),new Avalonia.Point(6, 17),new Avalonia.Point(17, 17),new Avalonia.Point(17, 15),new Avalonia.Point(8, 15)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,3H10v10h12V3z M20,11h-8V7h8V11z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(4, 12),new Avalonia.Point(2, 12),new Avalonia.Point(2, 21),new Avalonia.Point(13, 21),new Avalonia.Point(13, 19),new Avalonia.Point(4, 19)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

