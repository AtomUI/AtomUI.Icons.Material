// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceSignalWifiStatusbar1BarTwoTone : Icon
{
    public DeviceSignalWifiStatusbar1BarTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M17.65,15.34L24,8.98C20.93,5.9,16.69,4,12,4C7.31,4,3.07,5.9,0,8.98l6.35,6.36 C7.8,13.89,9.79,13,12,13S16.2,13.89,17.65,15.34z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M17.65,15.34C16.2,13.89,14.21,13,12,13s-4.2,0.89-5.65,2.34L12,21L17.65,15.34z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

