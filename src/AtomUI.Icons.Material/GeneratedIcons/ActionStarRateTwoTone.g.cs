// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionStarRateTwoTone : MaterialIcon
{
    public ActionStarRateTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 2, 20, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(12.94, 12),new Avalonia.Point(12, 8.89),new Avalonia.Point(11.06, 12),new Avalonia.Point(8.24, 12),new Avalonia.Point(10.51, 13.62),new Avalonia.Point(9.58, 16.63),new Avalonia.Point(12, 14.79),new Avalonia.Point(14.42, 16.63),new Avalonia.Point(13.49, 13.62),new Avalonia.Point(15.76, 12)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M22,10h-7.58L12,2l-2.42,8H2l6.17,4.41L5.83,22L12,17.31L18.17,22l-2.35-7.59L22,10z M14.42,16.63L12,14.79l-2.42,1.84 l0.93-3.01L8.24,12h2.82L12,8.89L12.94,12h2.82l-2.27,1.62L14.42,16.63z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

