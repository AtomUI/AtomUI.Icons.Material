// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareKeyboardControlKeySharp : MaterialIcon
{
    public HardwareKeyboardControlKeySharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 5, 14, 8.4100000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.263157894736842, 0, 0, 1.263157894736842, -3.1578947368421044, -3.1578947368421044);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(5, 12),new Avalonia.Point(6.41, 13.41),new Avalonia.Point(12, 7.83),new Avalonia.Point(17.59, 13.41),new Avalonia.Point(19, 12),new Avalonia.Point(12, 5)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

