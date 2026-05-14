// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareKeyboardDoubleArrowDownSharp : MaterialIcon
{
    public HardwareKeyboardDoubleArrowDownSharp()
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
            Points = [new Avalonia.Point(18, 6.41),new Avalonia.Point(16.59, 5),new Avalonia.Point(12, 9.58),new Avalonia.Point(7.41, 5),new Avalonia.Point(6, 6.41),new Avalonia.Point(12, 12.41)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(18, 13),new Avalonia.Point(16.59, 11.59),new Avalonia.Point(12, 16.17),new Avalonia.Point(7.41, 11.59),new Avalonia.Point(6, 13),new Avalonia.Point(12, 19)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

