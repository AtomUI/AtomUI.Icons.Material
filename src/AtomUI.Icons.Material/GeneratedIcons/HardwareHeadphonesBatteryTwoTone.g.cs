// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class HardwareHeadphonesBatteryTwoTone : Icon
{
    public HardwareHeadphonesBatteryTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(18, 9, 2, 7),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M21,7h-1V6h-2v1h-1c-0.55,0-1,0.45-1,1v9c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1V8C22,7.45,21.55,7,21,7z M20,16h-2V9h2 V16z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M8,6c-3.31,0-6,2.69-6,6v4c0,1.1,0.9,2,2,2h2v-5H3.5v-1c0-2.48,2.02-4.5,4.5-4.5s4.5,2.02,4.5,4.5v1H10v5h2 c1.1,0,2-0.9,2-2v-4C14,8.69,11.31,6,8,6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

