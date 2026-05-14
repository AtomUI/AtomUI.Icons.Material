// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionViewInArSharp : MaterialIcon
{
    public ActionViewInArSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 22, 22);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(18, 1),new Avalonia.Point(18, 3),new Avalonia.Point(21, 3),new Avalonia.Point(21, 6),new Avalonia.Point(23, 6),new Avalonia.Point(23, 1)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(21, 21),new Avalonia.Point(18, 21),new Avalonia.Point(18, 23),new Avalonia.Point(23, 23),new Avalonia.Point(23, 18),new Avalonia.Point(21, 18)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(3, 3),new Avalonia.Point(6, 3),new Avalonia.Point(6, 1),new Avalonia.Point(1, 1),new Avalonia.Point(1, 6),new Avalonia.Point(3, 6)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(3, 18),new Avalonia.Point(1, 18),new Avalonia.Point(1, 23),new Avalonia.Point(6, 23),new Avalonia.Point(6, 21),new Avalonia.Point(3, 21)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19,7.97l-7-4.03L5,7.97v8.06l7,4.03l7-4.03V7.97z M11,17.17l-4-2.3v-4.63l4,2.33V17.17z M12,10.84L8.04,8.53L12,6.25 l3.96,2.28L12,10.84z M17,14.87l-4,2.3v-4.6l4-2.33V14.87z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

