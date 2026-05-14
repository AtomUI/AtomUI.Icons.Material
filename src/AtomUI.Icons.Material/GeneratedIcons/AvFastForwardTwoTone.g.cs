// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class AvFastForwardTwoTone : MaterialIcon
{
    public AvFastForwardTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 6, 17.5, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2972972972972974, 0, 0, 1.2972972972972974, -3.5675675675675684, -3.5675675675675684);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(15, 9.86),new Avalonia.Point(15, 14.14),new Avalonia.Point(18.03, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6, 9.86),new Avalonia.Point(6, 14.14),new Avalonia.Point(9.03, 12)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M4,18l8.5-6L4,6V18z M6,9.86L9.03,12L6,14.14V9.86z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M21.5,12L13,6v12L21.5,12z M15,9.86L18.03,12L15,14.14V9.86z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

