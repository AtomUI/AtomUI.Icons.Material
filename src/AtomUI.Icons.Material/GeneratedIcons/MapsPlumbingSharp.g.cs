// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsPlumbingSharp : Icon
{
    public MapsPlumbingSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M16.16,5.64l3.54,3.54c1.17-1.17,1.17-3.07,0-4.24l-3.54-3.54l-4.24,4.24l2.12,2.12L16.16,5.64z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(5.17, 10.5, 5, 3),
            RadiusX = 0,
            RadiusY = 0,
            Transform = TransformParser.Parse("matrix(0.7071 -0.7071 0.7071 0.7071 -6.2383 8.9393)").Value
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15.45,7.76l-1.41,1.41L9.79,4.93L7.67,7.05l4.24,4.24l-8.49,8.49l2.83,2.83L16.86,12l0.71,0.71l1.41-1.41L15.45,7.76z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

