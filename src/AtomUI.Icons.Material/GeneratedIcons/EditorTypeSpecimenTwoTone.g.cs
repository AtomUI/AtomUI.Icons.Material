// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class EditorTypeSpecimenTwoTone : Icon
{
    public EditorTypeSpecimenTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(14.04, 7.17),new Point(13.96, 7.17),new Point(12.65, 10.89),new Point(15.34, 10.89)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M8,16h12V4H8V16z M13.2,5.5h1.61l3.38,9h-1.56l-0.8-2.3h-3.63l-0.82,2.3H9.81L13.2,5.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M4,6H2v14c0,1.1,0.9,2,2,2h14v-2H4V6z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,2H8C6.9,2,6,2.9,6,4v12c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2V4C22,2.9,21.1,2,20,2z M20,16H8V4h12V16z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M12.19,12.2h3.63l0.8,2.3h1.56l-3.38-9H13.2l-3.38,9h1.56L12.19,12.2z M13.96,7.17h0.08l1.31,3.72h-2.69L13.96,7.17z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

