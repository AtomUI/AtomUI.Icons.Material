// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class SocialMan3Filled : Icon
{
    public SocialMan3Filled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M14,7h-4C8.9,7,8,7.9,8,9v6h2v7h4v-7h2V9C16,7.9,15.1,7,14,7z"),
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

