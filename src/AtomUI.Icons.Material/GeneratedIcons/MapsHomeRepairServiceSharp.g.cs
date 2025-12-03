// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsHomeRepairServiceSharp : Icon
{
    public MapsHomeRepairServiceSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(18, 16),new Point(16, 16),new Point(16, 15),new Point(8, 15),new Point(8, 16),new Point(6, 16),new Point(6, 15),new Point(2, 15),new Point(2, 20),new Point(22, 20),new Point(22, 15),new Point(18, 15)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M17,8V4H7v4H2v6h4v-2h2v2h8v-2h2v2h4V8H17z M9,6h6v2H9V6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

