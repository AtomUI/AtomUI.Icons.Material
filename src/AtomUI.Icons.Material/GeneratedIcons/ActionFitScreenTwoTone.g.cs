// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionFitScreenTwoTone : Icon
{
    public ActionFitScreenTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(8, 10, 8, 4),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M6,16h12V8H6V16z M8,10h8v4H8V10z M4,15H2v3c0,1.1,0.9,2,2,2h3v-2H4V15z M4,6h3V4H4C2.9,4,2,4.9,2,6v3h2V6z M20,4h-3v2h3v3 h2V6C22,4.9,21.1,4,20,4z M20,18h-3v2h3c1.1,0,2-0.9,2-2v-3h-2V18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

