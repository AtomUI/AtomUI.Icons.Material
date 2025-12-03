// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class SocialTornadoTwoTone : Icon
{
    public SocialTornadoTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(9.1, 13),new Point(14.9, 13),new Point(16.64, 10),new Point(7.36, 10)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(12, 18.01),new Point(13.74, 15),new Point(10.26, 15)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(4.47, 5),new Point(6.21, 8),new Point(17.79, 8),new Point(19.53, 5)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M1,3l11,19L23,3H1z M12,18.01L10.26,15h3.48L12,18.01z M14.9,13H9.1l-1.74-3h9.27L14.9,13z M6.21,8L4.47,5h15.06l-1.74,3 H6.21z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

