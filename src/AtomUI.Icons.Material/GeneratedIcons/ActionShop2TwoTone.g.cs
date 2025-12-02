// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionShop2TwoTone : Icon
{
    public ActionShop2TwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M7,16h14V7H7V16z M12,8l5.5,3.5L12,15V8z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M3,9H1v11c0,1.11,0.89,2,2,2h16v-2H3V9z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M18,5V3c0-1.11-0.89-2-2-2h-4c-1.11,0-2,0.89-2,2v2H5v11c0,1.11,0.89,2,2,2h14c1.11,0,2-0.89,2-2V5H18z M12,3h4v2h-4V3z M21,16H7V7h14V16z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(12, 8),new Point(12, 15),new Point(17.5, 11.5)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

