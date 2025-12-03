// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceMonitorHeartFilled : Icon
{
    public DeviceMonitorHeartFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15.11,12.45L14,10.24l-3.11,6.21C10.73,16.79,10.38,17,10,17s-0.73-0.21-0.89-0.55L7.38,13H2v5c0,1.1,0.9,2,2,2h16 c1.1,0,2-0.9,2-2v-5h-6C15.62,13,15.27,12.79,15.11,12.45z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,4H4C2.9,4,2,4.9,2,6v5h6c0.38,0,0.73,0.21,0.89,0.55L10,13.76l3.11-6.21c0.34-0.68,1.45-0.68,1.79,0L16.62,11H22V6 C22,4.9,21.1,4,20,4z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

