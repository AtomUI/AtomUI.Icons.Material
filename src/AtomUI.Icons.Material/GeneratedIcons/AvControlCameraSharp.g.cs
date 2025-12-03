// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class AvControlCameraSharp : Icon
{
    public AvControlCameraSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5.54 8.46L2 12l3.54 3.54 1.76-1.77L5.54 12l1.76-1.77zm12.92 0l-1.76 1.77L18.46 12l-1.76 1.77 1.76 1.77L22 12zm-6.46 10l-1.77-1.76-1.77 1.76L12 22l3.54-3.54-1.77-1.76zM8.46 5.54l1.77 1.76L12 5.54l1.77 1.76 1.77-1.76L12 2z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Point(12, 12),
            Radius = 3
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

