// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class NotificationDirectionsOffSharp : Icon
{
    public NotificationDirectionsOffSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(13, 7.5),new Point(16.5, 11),new Point(15.17, 12.34),new Point(18.62, 15.79),new Point(22.41, 12),new Point(12.01, 1.58),new Point(8.21, 5.38),new Point(13, 10.17)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("m1.39 4.22 3.99 3.99L1.59 12l10.42 10.4 3.79-3.79 3.99 3.99 1.41-1.41L2.81 2.81 1.39 4.22zm8.6 8.6V15h-2v-4.18l2 2z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

