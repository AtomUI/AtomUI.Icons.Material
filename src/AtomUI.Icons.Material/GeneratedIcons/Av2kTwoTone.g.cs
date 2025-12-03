// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class Av2kTwoTone : Icon
{
    public Av2kTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5,19h14V5H5V19z M13,9h1.5v2.25L16.25,9H18l-2.25,3L18,15h-1.75l-1.75-2.25V15H13V9z M6.5,12.5 c0-0.55,0.45-1,1-1h2v-1h-3V9H10c0.55,0,1,0.45,1,1v1.5c0,0.55-0.45,1-1,1H8v1h3V15H6.5V12.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M19,19H5V5h14V19z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M11,13.5H8v-1h2c0.55,0,1-0.45,1-1V10c0-0.55-0.45-1-1-1H6.5v1.5h3v1h-2c-0.55,0-1,0.45-1,1V15H11V13.5z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(14.5, 12.75),new Point(16.25, 15),new Point(18, 15),new Point(15.75, 12),new Point(18, 9),new Point(16.25, 9),new Point(14.5, 11.25),new Point(14.5, 9),new Point(13, 9),new Point(13, 15),new Point(14.5, 15)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

