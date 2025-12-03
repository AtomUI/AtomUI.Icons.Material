// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsEggSharp : Icon
{
    public MapsEggSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,3C8.5,3,5,9.33,5,14c0,3.87,3.13,7,7,7s7-3.13,7-7C19,9.33,15.5,3,12,3z M13,18c-3,0-5-1.99-5-5c0-0.55,0-1,0-1h2 c0,0,0,1,0,1c0,2.92,2.42,3,3,3c0.55,0,1,0,1,0l0,2C14,18,13.55,18,13,18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

