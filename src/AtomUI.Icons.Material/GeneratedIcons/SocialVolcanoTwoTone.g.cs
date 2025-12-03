// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class SocialVolcanoTwoTone : Icon
{
    public SocialVolcanoTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(16.49, 10),new Point(12.35, 10),new Point(10.86, 13.74),new Point(10.35, 15),new Point(9, 15),new Point(7.3, 15),new Point(5.08, 20),new Point(19.35, 20)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M18,8h-7l-2,5H6l-4,9h20L18,8z M7.3,15H9h1.35l0.5-1.26l1.5-3.74h4.14l2.86,10H5.08L7.3,15z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(13, 1, 2, 4),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(16.24, 3.76, 4, 2),
            RadiusX = 0,
            RadiusY = 0,
            Transform = TransformParser.Parse("matrix(0.7071 -0.7071 0.7071 0.7071 1.9792 14.2929)").Value
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(8.76, 2.76, 2, 4),
            RadiusX = 0,
            RadiusY = 0,
            Transform = TransformParser.Parse("matrix(0.7071 -0.7071 0.7071 0.7071 -0.5061 8.2929)").Value
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

