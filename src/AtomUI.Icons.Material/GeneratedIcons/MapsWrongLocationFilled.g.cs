// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsWrongLocationFilled : MaterialIcon
{
    public MapsWrongLocationFilled()
    {
        IconTheme = IconThemeType.Filled;
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
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M14,10V3.26C13.35,3.09,12.68,3,12,3c-4.2,0-8,3.22-8,8.2c0,3.32,2.67,7.25,8,11.8c5.33-4.55,8-8.48,8-11.8 c0-0.41-0.04-0.81-0.09-1.2H14z M12,13c-1.1,0-2-0.9-2-2c0-1.1,0.9-2,2-2s2,0.9,2,2C14,12.1,13.1,13,12,13z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(22.54, 2.88),new Avalonia.Point(21.12, 1.46),new Avalonia.Point(19, 3.59),new Avalonia.Point(16.88, 1.46),new Avalonia.Point(15.46, 2.88),new Avalonia.Point(17.59, 5),new Avalonia.Point(15.46, 7.12),new Avalonia.Point(16.88, 8.54),new Avalonia.Point(19, 6.41),new Avalonia.Point(21.12, 8.54),new Avalonia.Point(22.54, 7.12),new Avalonia.Point(20.41, 5)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

