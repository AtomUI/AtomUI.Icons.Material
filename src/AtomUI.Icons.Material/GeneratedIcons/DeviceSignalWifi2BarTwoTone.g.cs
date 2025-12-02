// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceSignalWifi2BarTwoTone : Icon
{
    public DeviceSignalWifi2BarTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M23.64 7c-.45-.34-4.93-4-11.64-4C5.28 3 .81 6.66.36 7L12 21.5 23.64 7z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M4.79 12.52L12 21.5l7.21-8.99C18.85 12.24 16.1 10 12 10s-6.85 2.24-7.21 2.52z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

