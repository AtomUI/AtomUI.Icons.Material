// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionExpandOutlined : Icon
{
    public ActionExpandOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(4, 20, 16, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(4, 2, 16, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(9.41, 13.59),new Point(8, 15),new Point(12, 19),new Point(16, 15),new Point(14.59, 13.59),new Point(13, 15.17),new Point(13, 8.83),new Point(14.59, 10.41),new Point(16, 9),new Point(12, 5),new Point(8, 9),new Point(9.41, 10.41),new Point(11, 8.83),new Point(11, 15.17)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

