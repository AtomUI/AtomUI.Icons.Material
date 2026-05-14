// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorDataArrayTwoTone : MaterialIcon
{
    public EditorDataArrayTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 4, 16, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(15, 4),new Avalonia.Point(15, 6),new Avalonia.Point(18, 6),new Avalonia.Point(18, 18),new Avalonia.Point(15, 18),new Avalonia.Point(15, 20),new Avalonia.Point(20, 20),new Avalonia.Point(20, 4)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(4, 20),new Avalonia.Point(9, 20),new Avalonia.Point(9, 18),new Avalonia.Point(6, 18),new Avalonia.Point(6, 6),new Avalonia.Point(9, 6),new Avalonia.Point(9, 4),new Avalonia.Point(4, 4)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

