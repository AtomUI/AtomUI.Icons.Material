// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ImageBrushTwoTone : Icon
{
    public ImageBrushTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M8 17c0-.55-.45-1-1-1s-1 .45-1 1c0 .74-.19 1.4-.5 1.95.17.03.33.05.5.05 1.1 0 2-.9 2-2z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M11.75 15l8.96-8.96c.39-.39.39-1.02 0-1.41l-1.34-1.34c-.2-.2-.45-.29-.7-.29s-.51.1-.71.29L9 12.25 11.75 15zM6 21c2.21 0 4-1.79 4-4 0-1.66-1.34-3-3-3s-3 1.34-3 3c0 1.31-1.16 2-2 2 .92 1.22 2.49 2 4 2zm0-4c0-.55.45-1 1-1s1 .45 1 1c0 1.1-.9 2-2 2-.17 0-.33-.02-.5-.05.31-.55.5-1.21.5-1.95z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

