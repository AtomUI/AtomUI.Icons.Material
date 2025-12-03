// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class SearchLivingSharp : Icon
{
    public SearchLivingSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(15.5, 12),new Point(15.5, 14.5),new Point(8.5, 14.5),new Point(8.5, 12),new Point(7.52, 12),new Point(6.5, 12),new Point(6.5, 16.5),new Point(17.5, 16.5),new Point(17.5, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(10, 10),new Point(10, 13),new Point(14, 13),new Point(14, 10),new Point(16.25, 9.99),new Point(16.25, 7.5),new Point(7.75, 7.5),new Point(7.75, 9.99)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,2H2v20h20V2z M19,9.99V18H5v-8l1.25-0.01V6h11.5v3.99H19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

