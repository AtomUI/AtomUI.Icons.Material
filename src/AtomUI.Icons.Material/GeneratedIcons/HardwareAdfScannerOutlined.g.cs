// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class HardwareAdfScannerOutlined : Icon
{
    public HardwareAdfScannerOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19,12h-1V4H6v8H5c-1.66,0-3,1.34-3,3v5h20v-5C22,13.34,20.66,12,19,12z M8,6h8v6H8V6z M20,18H4v-3c0-0.55,0.45-1,1-1h14 c0.55,0,1,0.45,1,1V18z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Center = new Point(18, 16),
            Radius = 1
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

