// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class EditorHexagonSharp : Icon
{
    public EditorHexagonSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(17.2, 3),new Point(6.8, 3),new Point(1.6, 12),new Point(6.8, 21),new Point(17.2, 21),new Point(22.4, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

