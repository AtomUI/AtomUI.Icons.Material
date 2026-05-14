// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialIosShareSharp : MaterialIcon
{
    public SocialIosShareSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 1, 16, 22);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(20, 8),new Avalonia.Point(15, 8),new Avalonia.Point(15, 10),new Avalonia.Point(18, 10),new Avalonia.Point(18, 21),new Avalonia.Point(6, 21),new Avalonia.Point(6, 10),new Avalonia.Point(9, 10),new Avalonia.Point(9, 8),new Avalonia.Point(4, 8),new Avalonia.Point(4, 23),new Avalonia.Point(20, 23)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(11, 16),new Avalonia.Point(13, 16),new Avalonia.Point(13, 5),new Avalonia.Point(16, 5),new Avalonia.Point(12, 1),new Avalonia.Point(8, 5),new Avalonia.Point(11, 5)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

