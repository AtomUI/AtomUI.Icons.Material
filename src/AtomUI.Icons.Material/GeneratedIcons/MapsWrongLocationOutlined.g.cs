// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsWrongLocationOutlined : MaterialIcon
{
    public MapsWrongLocationOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 1.46, 18.539999999999999, 21.539999999999999);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0869565217391306, 0, 0, 1.0869565217391306, -1.0434782608695663, -1.0434782608695663);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M18,11c0,0.07,0,0.13,0,0.2c0,2.34-1.95,5.44-6,9.14c-4.05-3.7-6-6.79-6-9.14C6,7.57,8.65,5,12,5c0.34,0,0.68,0.03,1,0.08 V3.06C12.67,3.02,12.34,3,12,3c-4.2,0-8,3.22-8,8.2c0,3.32,2.67,7.25,8,11.8c5.33-4.55,8-8.48,8-11.8c0-0.07,0-0.13,0-0.2H18z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Center = new Avalonia.Point(12, 11),
            Radius = 2
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(22.54, 2.88),new Avalonia.Point(21.12, 1.46),new Avalonia.Point(19, 3.59),new Avalonia.Point(16.88, 1.46),new Avalonia.Point(15.46, 2.88),new Avalonia.Point(17.59, 5),new Avalonia.Point(15.46, 7.12),new Avalonia.Point(16.88, 8.54),new Avalonia.Point(19, 6.41),new Avalonia.Point(21.12, 8.54),new Avalonia.Point(22.54, 7.12),new Avalonia.Point(20.41, 5)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

