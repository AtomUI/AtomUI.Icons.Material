// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionInstallMobileSharp : MaterialIcon
{
    public ActionInstallMobileSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 1, 18, 22);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(17, 18),new Avalonia.Point(7, 18),new Avalonia.Point(7, 6),new Avalonia.Point(14, 6),new Avalonia.Point(14, 1),new Avalonia.Point(5, 1),new Avalonia.Point(5, 23),new Avalonia.Point(19, 23),new Avalonia.Point(19, 16),new Avalonia.Point(17, 16)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(18, 14),new Avalonia.Point(23, 9),new Avalonia.Point(21.59, 7.59),new Avalonia.Point(19, 10.17),new Avalonia.Point(19, 3),new Avalonia.Point(17, 3),new Avalonia.Point(17, 10.17),new Avalonia.Point(14.41, 7.59),new Avalonia.Point(13, 9)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

