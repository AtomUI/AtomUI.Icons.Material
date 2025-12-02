// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class AvMovieEditFilled : Icon
{
    public AvMovieEditFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M4 10h18V6c0-1.1-.9-2-2-2h-3l2 4h-3l-2-4h-2l2 4h-3L9 4H7l2 4H6L4 4c-1.1 0-1.99.9-1.99 2L2 18c0 1.1.9 2 2 2h8v-2H4v-8z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(14, 18.88),new Point(14, 21),new Point(16.12, 21),new Point(21.29, 15.83),new Point(19.17, 13.71)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("m22.71 13-.71-.71c-.39-.39-1.02-.39-1.41 0l-.71.71L22 15.12l.71-.71c.39-.39.39-1.02 0-1.41z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

