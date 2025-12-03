// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ImageMpTwoTone : Icon
{
    public ImageMpTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(15, 10.5, 1.5, 1.5),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5,5l0,14l14,0l0-14H5z M12.5,15H11v-4.5h-1v3H8.5v-3h-1V15H6v-5c0-0.55,0.45-1,1-1h4.5c0.55,0,1,0.45,1,1 V15z M18,12.5c0,0.55-0.45,1-1,1h-2V15h-1.5V9H17c0.55,0,1,0.45,1,1V12.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M17,9h-3.5v6H15v-1.5h2c0.55,0,1-0.45,1-1V10C18,9.45,17.55,9,17,9z M16.5,12H15v-1.5h1.5V12z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M11.5,9H7c-0.55,0-1,0.45-1,1v5h1.5v-4.5h1v3H10v-3h1V15h1.5v-5C12.5,9.45,12.05,9,11.5,9z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19,3H5C3.9,3,3,3.9,3,5V19c0,1.1,0.9,2,2,2H19c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M5,19L5,5h14l0,14L5,19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

