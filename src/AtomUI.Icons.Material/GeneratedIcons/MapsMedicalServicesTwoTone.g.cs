// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsMedicalServicesTwoTone : Icon
{
    public MapsMedicalServicesTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M4,20h16V8H4V20z M8,13h3v-3h2v3h3v2h-3v3h-2v-3H8V13z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,6h-4V4c0-1.1-0.9-2-2-2h-4C8.9,2,8,2.9,8,4v2H4C2.9,6,2,6.9,2,8v12c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V8 C22,6.9,21.1,6,20,6z M10,4h4v2h-4V4z M20,20H4V8h16V20z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(11, 18),new Point(13, 18),new Point(13, 15),new Point(16, 15),new Point(16, 13),new Point(13, 13),new Point(13, 10),new Point(11, 10),new Point(11, 13),new Point(8, 13),new Point(8, 15),new Point(11, 15)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

