// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareKeyboardDoubleArrowUpSharp : MaterialIcon
{
    public HardwareKeyboardDoubleArrowUpSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 5, 12, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.263157894736842, 0, 0, 1.263157894736842, -3.1578947368421044, -3.1578947368421044);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6, 17.59),new Avalonia.Point(7.41, 19),new Avalonia.Point(12, 14.42),new Avalonia.Point(16.59, 19),new Avalonia.Point(18, 17.59),new Avalonia.Point(12, 11.59)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6, 11),new Avalonia.Point(7.41, 12.41),new Avalonia.Point(12, 7.83),new Avalonia.Point(16.59, 12.41),new Avalonia.Point(18, 11),new Avalonia.Point(12, 5)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

