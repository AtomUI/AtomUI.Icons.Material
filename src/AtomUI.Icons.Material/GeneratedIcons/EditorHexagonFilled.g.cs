// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorHexagonFilled : MaterialIcon
{
    public EditorHexagonFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.6000000000000001, 3, 20.799999999999997, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0714285714285714, 0, 0, 1.0714285714285714, -0.85714285714285765, -0.85714285714285765);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(17.2, 3),new Avalonia.Point(6.8, 3),new Avalonia.Point(1.6, 12),new Avalonia.Point(6.8, 21),new Avalonia.Point(17.2, 21),new Avalonia.Point(22.4, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

