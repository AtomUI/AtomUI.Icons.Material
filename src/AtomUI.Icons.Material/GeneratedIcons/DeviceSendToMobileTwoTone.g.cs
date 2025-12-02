// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceSendToMobileTwoTone : Icon
{
    public DeviceSendToMobileTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(7, 3, 10, 1),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(7, 20, 10, 1),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M22,12l-4-4v3h-5v2h5v3L22,12z M17,18H7V6h10v1h2V3c0-1.1-0.9-2-2-2L7,1.01C5.9,1.01,5,1.9,5,3v18c0,1.1,0.9,2,2,2h10 c1.1,0,2-0.9,2-2v-4h-2V18z M7,3h10v1H7V3z M17,21H7v-1h10V21z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

