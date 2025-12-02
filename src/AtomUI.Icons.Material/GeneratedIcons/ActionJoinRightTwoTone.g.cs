// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionJoinRightTwoTone : Icon
{
    public ActionJoinRightTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new EllipseDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Center = new Point(12, 12),
            RadiusX = 3,
            RadiusY = 5.74
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M16.5,12c0,0.97-0.23,4.16-3.03,6.5C14.25,18.81,15.1,19,16,19c3.86,0,7-3.14,7-7s-3.14-7-7-7c-0.9,0-1.75,0.19-2.53,0.5 C16.27,7.84,16.5,11.03,16.5,12z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M8,19c0.9,0,1.75-0.19,2.53-0.5c-0.61-0.51-1.1-1.07-1.49-1.63C8.71,16.95,8.36,17,8,17c-2.76,0-5-2.24-5-5s2.24-5,5-5 c0.36,0,0.71,0.05,1.04,0.13c0.39-0.56,0.88-1.12,1.49-1.63C9.75,5.19,8.9,5,8,5c-3.86,0-7,3.14-7,7S4.14,19,8,19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

