// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class EditorDataArrayOutlined : Icon
{
    public EditorDataArrayOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(15, 4),new Point(15, 6),new Point(18, 6),new Point(18, 18),new Point(15, 18),new Point(15, 20),new Point(20, 20),new Point(20, 4)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(4, 20),new Point(9, 20),new Point(9, 18),new Point(6, 18),new Point(6, 6),new Point(9, 6),new Point(9, 4),new Point(4, 4)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

