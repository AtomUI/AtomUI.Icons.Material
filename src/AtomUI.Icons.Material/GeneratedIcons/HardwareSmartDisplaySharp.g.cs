// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class HardwareSmartDisplaySharp : Icon
{
    public HardwareSmartDisplaySharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,4H2v16h20V4z M9.5,16.5v-9l7,4.5L9.5,16.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

