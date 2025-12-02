// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsHardwareTwoTone : Icon
{
    public MapsHardwareTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6.77,6H11v5h2V5H9C8.11,5,7.32,5.39,6.77,6z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(11, 13, 2, 6),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M18,3l-3,3V3H9C6.24,3,4,5.24,4,8h5v12c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1V8l3,3h2V3H18z M13,19h-2v-6h2V19z M13,11 h-2V6H6.77C7.32,5.39,8.11,5,9,5h4V11z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

