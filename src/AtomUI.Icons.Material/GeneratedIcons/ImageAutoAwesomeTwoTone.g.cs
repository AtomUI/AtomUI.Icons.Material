// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ImageAutoAwesomeTwoTone : Icon
{
    public ImageAutoAwesomeTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(9.99, 11.01),new Point(9, 8.83),new Point(8.01, 11.01),new Point(5.83, 12),new Point(8.01, 12.99),new Point(9, 15.17),new Point(9.99, 12.99),new Point(12.17, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(19, 9),new Point(20.25, 6.25),new Point(23, 5),new Point(20.25, 3.75),new Point(19, 1),new Point(17.75, 3.75),new Point(15, 5),new Point(17.75, 6.25)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(19, 15),new Point(17.75, 17.75),new Point(15, 19),new Point(17.75, 20.25),new Point(19, 23),new Point(20.25, 20.25),new Point(23, 19),new Point(20.25, 17.75)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M11.5,9.5L9,4L6.5,9.5L1,12l5.5,2.5L9,20l2.5-5.5L17,12L11.5,9.5z M9.99,12.99L9,15.17l-0.99-2.18L5.83,12l2.18-0.99 L9,8.83l0.99,2.18L12.17,12L9.99,12.99z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

