// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class EditorPolylineSharp : Icon
{
    public EditorPolylineSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(15, 16),new Point(15, 17.26),new Point(9, 14.26),new Point(9, 11.09),new Point(11.7, 8),new Point(16, 8),new Point(16, 2),new Point(10, 2),new Point(10, 6.9),new Point(7.3, 10),new Point(3, 10),new Point(3, 16),new Point(8, 16),new Point(15, 19.5),new Point(15, 22),new Point(21, 22),new Point(21, 16)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

