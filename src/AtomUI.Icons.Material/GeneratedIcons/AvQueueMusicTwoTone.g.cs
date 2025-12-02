// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class AvQueueMusicTwoTone : Icon
{
    public AvQueueMusicTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Center = new Point(16, 17),
            Radius = 1
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M3,10h12v2H3V10z M3,14h8v2H3V14z M3,6h12v2H3V6z M17,14.18C16.69,14.07,16.35,14,16,14c-1.66,0-3,1.34-3,3s1.34,3,3,3 s3-1.34,3-3V8h3V6h-5V14.18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

