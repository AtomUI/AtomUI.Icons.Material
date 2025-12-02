// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionThumbUpOffAltTwoTone : Icon
{
    public ActionThumbUpOffAltTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(13.34, 4.66),new Point(9, 9),new Point(9, 19),new Point(18, 19),new Point(21, 12),new Point(21, 10),new Point(12.23, 10)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M21,8h-6.31l0.95-4.57l0.03-0.32c0-0.41-0.17-0.79-0.44-1.06L14.17,1L7.59,7.59C7.22,7.95,7,8.45,7,9v10c0,1.1,0.9,2,2,2 h9c0.83,0,1.54-0.5,1.84-1.22l3.02-7.05C22.95,12.5,23,12.26,23,12v-2C23,8.9,22.1,8,21,8z M21,12l-3,7H9V9l4.34-4.34L12.23,10H21 V12z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(1, 9, 4, 12),
            RadiusX = 0,
            RadiusY = 0,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

