// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsTempleBuddhistTwoTone : Icon
{
    public MapsTempleBuddhistTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(12, 4.33),new Point(10, 7),new Point(14, 7)]
        },
        new RectDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(8, 9, 8, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6,20h3v-2c0-1.65,1.35-3,3-3c1.65,0,3,1.35,3,3v2h3v-7H6V20z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M21,9.02c0,1.09-0.89,1.98-1.98,1.98H18V8.86c1.72-0.44,3-1.99,3-3.84V5l-2,0.02C19,6.11,18.11,7,17.02,7H16.5L12,1L7.5,7 H6.98C5.89,7,5,6.11,5,5.02H3c0,1.86,1.28,3.4,3,3.84V11H4.98C3.89,11,3,10.11,3,9.02H1c0,1.86,1.28,3.4,3,3.84V22h7v-4 c0-0.55,0.45-1,1-1s1,0.45,1,1v4h7v-9.14c1.72-0.44,3-1.99,3-3.84V9L21,9.02z M12,4.33L14,7h-4L12,4.33z M8,9h8v2H8V9z M18,20h-3 v-2c0-1.65-1.35-3-3-3c-1.65,0-3,1.35-3,3v2H6v-7h12V20z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

