// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionInvertColorsTwoTone : Icon
{
    public ActionInvertColorsTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M7.75,8.99C6.62,10.1,6,11.57,6,13.13C6,16.37,8.69,19,12,19l0-14.19L7.75,8.99z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M17.65,7.56L17.65,7.56L12,2L6.35,7.56l0,0C4.9,8.99,4,10.96,4,13.13C4,17.48,7.58,21,12,21c4.42,0,8-3.52,8-7.87 C20,10.96,19.1,8.99,17.65,7.56z M6,13.13c0-1.56,0.62-3.03,1.75-4.14L12,4.81L12,19C8.69,19,6,16.37,6,13.13z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

