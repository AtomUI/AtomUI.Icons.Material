// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsAddLocationSharp : Icon
{
    public MapsAddLocationSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13,6h-2v3H8v2h3v3h2v-3h3V9h-3V6z M12,2c4.2,0,8,3.22,8,8.2c0,3.32-2.67,7.25-8,11.8 c-5.33-4.55-8-8.48-8-11.8C4,5.22,7.8,2,12,2z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

