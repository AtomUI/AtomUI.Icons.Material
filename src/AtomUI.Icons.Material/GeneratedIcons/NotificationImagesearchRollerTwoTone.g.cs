// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class NotificationImagesearchRollerTwoTone : Icon
{
    public NotificationImagesearchRollerTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(8, 4, 10, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(12, 17, 2, 4),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,7V3c0-0.55-0.45-1-1-1H7C6.45,2,6,2.45,6,3v1H4C2.9,4,2,4.9,2,6v4c0,1.1,0.9,2,2,2h8v3h-1c-0.55,0-1,0.45-1,1v6 c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1v-6c0-0.55-0.45-1-1-1h-1v-3c0-1.1-0.9-2-2-2H4V6h2v1c0,0.55,0.45,1,1,1h12 C19.55,8,20,7.55,20,7z M8,4h10v2H8V4z M14,21h-2v-4h2V21z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

