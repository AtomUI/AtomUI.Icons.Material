// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class PlacesChargingStationTwoTone : Icon
{
    public PlacesChargingStationTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M17,3v1H7V3H17 M17,20H7v1h10V20"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M14.5,11l-3,6v-4h-2l3-6v4H14.5z M17,3H7v1h10V3 M17,20H7v1h10V20 M17,1c1.1,0,2,0.9,2,2v18c0,1.1-0.9,2-2,2H7 c-1.1,0-2-0.9-2-2V3c0-1.1,0.9-2,2-2H17L17,1z M7,18h10V6H7V18L7,18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

