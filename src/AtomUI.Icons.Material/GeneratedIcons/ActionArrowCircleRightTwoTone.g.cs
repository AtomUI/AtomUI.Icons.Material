// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionArrowCircleRightTwoTone : Icon
{
    public ActionArrowCircleRightTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M4,12c0-4.41,3.59-8,8-8s8,3.59,8,8s-3.59,8-8,8S4,16.41,4,12 M12,11l-4,0v2l4,0v3l4-4l-4-4V11z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M4,12c0-4.41,3.59-8,8-8s8,3.59,8,8s-3.59,8-8,8S4,16.41,4,12 M2,12c0,5.52,4.48,10,10,10c5.52,0,10-4.48,10-10 c0-5.52-4.48-10-10-10C6.48,2,2,6.48,2,12L2,12z M12,11l-4,0v2l4,0v3l4-4l-4-4V11z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

