// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class NotificationAccountTreeTwoTone : MaterialIcon
{
    public NotificationAccountTreeTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 3, 20, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M22,11V3h-7v3H9V3H2v8h7V8h2v10h4v3h7v-8h-7v3h-2V8h2v3H22z M7,9H4V5h3V9z M17,15h3v4h-3V15z M17,5h3v4h-3V5z"),
        },
        new PolylineDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(7, 5),new Avalonia.Point(7, 9),new Avalonia.Point(4, 9),new Avalonia.Point(4, 5),new Avalonia.Point(7, 5)]
        },
        new PolylineDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(20, 5),new Avalonia.Point(20, 9),new Avalonia.Point(17, 9),new Avalonia.Point(17, 5),new Avalonia.Point(20, 5)]
        },
        new PolylineDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(20, 15),new Avalonia.Point(20, 19),new Avalonia.Point(17, 19),new Avalonia.Point(17, 15),new Avalonia.Point(20, 15)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

