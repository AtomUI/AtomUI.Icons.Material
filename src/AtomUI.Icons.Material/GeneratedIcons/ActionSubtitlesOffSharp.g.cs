// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionSubtitlesOffSharp : Icon
{
    public ActionSubtitlesOffSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(6.83, 4),new Point(14.83, 12),new Point(20, 12),new Point(20, 14),new Point(16.83, 14),new Point(22, 19.17),new Point(22, 4)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M1.04,3.87L2,4.83V20h15.17l2.96,2.96l1.41-1.41L2.45,2.45L1.04,3.87z M4,12h4v2H4V12z M4,16h9.17L14,16.83V18H4V16z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

