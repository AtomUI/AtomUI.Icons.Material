// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialPersonAddAlt1TwoTone : MaterialIcon
{
    public SocialPersonAddAlt1TwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 4, 22, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(9, 8),
            Radius = 2
        },
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M9,16c-2.7,0-5.8,1.29-6,2h12C14.78,17.28,11.69,16,9,16z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M9,14c-2.67,0-8,1.34-8,4v2h16v-2C17,15.34,11.67,14,9,14z M3,18c0.2-0.71,3.3-2,6-2c2.69,0,5.78,1.28,6,2H3z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(20, 10),new Avalonia.Point(20, 7),new Avalonia.Point(18, 7),new Avalonia.Point(18, 10),new Avalonia.Point(15, 10),new Avalonia.Point(15, 12),new Avalonia.Point(18, 12),new Avalonia.Point(18, 15),new Avalonia.Point(20, 15),new Avalonia.Point(20, 12),new Avalonia.Point(23, 12),new Avalonia.Point(23, 10)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M9,12c2.21,0,4-1.79,4-4c0-2.21-1.79-4-4-4S5,5.79,5,8C5,10.21,6.79,12,9,12z M9,6c1.1,0,2,0.9,2,2c0,1.1-0.9,2-2,2 S7,9.1,7,8C7,6.9,7.9,6,9,6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

