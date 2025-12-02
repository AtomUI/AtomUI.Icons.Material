// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class HardwareKeyboardOptionKeyOutlined : Icon
{
    public HardwareKeyboardOptionKeyOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(15, 5, 6, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(9, 5),new Point(3, 5),new Point(3, 7),new Point(7.85, 7),new Point(14.77, 19),new Point(21, 19),new Point(21, 17),new Point(15.93, 17)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

