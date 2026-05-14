// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionAppShortcutTwoTone : MaterialIcon
{
    public ActionAppShortcutTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 1, 18, 22);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(7, 20, 10, 1),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(7, 3, 10, 1),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M17,18H7V6h10v1h2V3c0-1.1-0.9-2-2-2H7C5.9,1,5,1.9,5,3v18c0,1.1,0.9,2,2,2h10c1.1,0,2-0.9,2-2v-4h-2V18z M7,3h10v1H7V3z M17,21H7v-1h10V21z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(20.38, 9.62),new Avalonia.Point(21, 11),new Avalonia.Point(21.62, 9.62),new Avalonia.Point(23, 9),new Avalonia.Point(21.62, 8.38),new Avalonia.Point(21, 7),new Avalonia.Point(20.38, 8.38),new Avalonia.Point(19, 9)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(16, 8),new Avalonia.Point(14.75, 10.75),new Avalonia.Point(12, 12),new Avalonia.Point(14.75, 13.25),new Avalonia.Point(16, 16),new Avalonia.Point(17.25, 13.25),new Avalonia.Point(20, 12),new Avalonia.Point(17.25, 10.75)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(21, 13),new Avalonia.Point(20.38, 14.38),new Avalonia.Point(19, 15),new Avalonia.Point(20.38, 15.62),new Avalonia.Point(21, 17),new Avalonia.Point(21.62, 15.62),new Avalonia.Point(23, 15),new Avalonia.Point(21.62, 14.38)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

