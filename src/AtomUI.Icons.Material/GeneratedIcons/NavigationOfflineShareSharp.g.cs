// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class NavigationOfflineShareSharp : Icon
{
    public NavigationOfflineShareSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(6, 5),new Point(4, 5),new Point(4, 23),new Point(16, 23),new Point(16, 21),new Point(6, 21)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,1H8v18h12V1z M18,15h-8V5h8V15z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(12.5, 10.25),new Point(14.5, 10.25),new Point(14.5, 12),new Point(17, 9.5),new Point(14.5, 7),new Point(14.5, 8.75),new Point(11, 8.75),new Point(11, 12),new Point(12.5, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

