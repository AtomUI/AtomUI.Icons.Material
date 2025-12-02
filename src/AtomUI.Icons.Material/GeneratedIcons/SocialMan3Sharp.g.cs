// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class SocialMan3Sharp : Icon
{
    public SocialMan3Sharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(16, 7),new Point(8, 7),new Point(8, 15),new Point(10, 15),new Point(10, 22),new Point(14, 22),new Point(14, 15),new Point(16, 15)]
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(10.41, 2.41, 3.18, 3.18),
            RadiusX = 0,
            RadiusY = 0,
            Transform = TransformParser.Parse("matrix(0.7071 0.7071 -0.7071 0.7071 6.3431 -7.3137)").Value
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

