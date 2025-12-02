// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsDirectionsRailwayFilledOutlined : Icon
{
    public MapsDirectionsRailwayFilledOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M12,2C8,2,4,2.5,4,6v9.5C4,17.43,5.57,19,7.5,19L6,20v1h12v-1l-1.5-1c1.93,0,3.5-1.57,3.5-3.5V6C20,2.5,16.42,2,12,2z M12,4c3.71,0,5.13,0.46,5.67,1H6.43C7.03,4.48,8.48,4,12,4z M18,15.5c0,0.83-0.67,1.5-1.5,1.5h-9C6.67,17,6,16.33,6,15.5V12h12 V15.5z M18,10H6V7h12V10z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Center = new Point(12, 14.5),
            Radius = 1.5
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

