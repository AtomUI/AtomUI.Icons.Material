// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceMedicationLiquidFilled : Icon
{
    public DeviceMedicationLiquidFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(3, 3, 12, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M14,6H4C2.9,6,2,6.9,2,8v11c0,1.1,0.9,2,2,2h10c1.1,0,2-0.9,2-2V8C16,6.9,15.1,6,14,6z M13,15h-2.5v2.5h-3V15H5v-3h2.5 V9.5h3V12H13V15z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,6c-1.68,0-3,1.76-3,4c0,1.77,0.83,3.22,2,3.76V20c0,0.55,0.45,1,1,1s1-0.45,1-1v-6.24c1.17-0.54,2-1.99,2-3.76 C23,7.76,21.68,6,20,6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

