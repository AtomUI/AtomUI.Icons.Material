// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareKeyboardDoubleArrowRightTwoTone : MaterialIcon
{
    public HardwareKeyboardDoubleArrowRightTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 6, 14, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.263157894736842, 0, 0, 1.263157894736842, -3.1578947368421044, -3.1578947368421044);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(6.41, 6),new Avalonia.Point(5, 7.41),new Avalonia.Point(9.58, 12),new Avalonia.Point(5, 16.59),new Avalonia.Point(6.41, 18),new Avalonia.Point(12.41, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(13, 6),new Avalonia.Point(11.59, 7.41),new Avalonia.Point(16.17, 12),new Avalonia.Point(11.59, 16.59),new Avalonia.Point(13, 18),new Avalonia.Point(19, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

