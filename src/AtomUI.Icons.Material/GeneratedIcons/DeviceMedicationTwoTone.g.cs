// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceMedicationTwoTone : Icon
{
    public DeviceMedicationTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M7,19h10V8H7V19z M8,12h2.5V9.5h3V12H16v3h-2.5v2.5h-3V15H8V12z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(6, 3, 12, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M17,6H7C5.9,6,5,6.9,5,8v11c0,1.1,0.9,2,2,2h10c1.1,0,2-0.9,2-2V8C19,6.9,18.1,6,17,6z M17,19H7V8h10V19z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(10.5, 17.5),new Point(13.5, 17.5),new Point(13.5, 15),new Point(16, 15),new Point(16, 12),new Point(13.5, 12),new Point(13.5, 9.5),new Point(10.5, 9.5),new Point(10.5, 12),new Point(8, 12),new Point(8, 15),new Point(10.5, 15)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

