// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class EditorTypeSpecimenSharp : Icon
{
    public EditorTypeSpecimenSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(4, 6),new Point(2, 6),new Point(2, 22),new Point(18, 22),new Point(18, 20),new Point(4, 20)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,2H6v16h16V2z M16.63,14.5l-0.8-2.3h-3.63l-0.82,2.3H9.81l3.38-9h1.61l3.38,9H16.63z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(13.96, 7.17),new Point(12.65, 10.89),new Point(15.34, 10.89),new Point(14.04, 7.17)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

