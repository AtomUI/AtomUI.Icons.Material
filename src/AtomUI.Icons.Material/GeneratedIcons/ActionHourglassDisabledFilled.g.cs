// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionHourglassDisabledFilled : Icon
{
    public ActionHourglassDisabledFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(8, 4),new Point(16, 4),new Point(16, 7.5),new Point(13.16, 10.34),new Point(14.41, 11.59),new Point(18, 8.01),new Point(17.99, 8),new Point(18, 8),new Point(18, 2),new Point(6, 2),new Point(6, 3.17),new Point(8, 5.17)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.1,2.1L0.69,3.51l8.9,8.9L6,16l0.01,0.01H6V22h12v-1.17l2.49,2.49l1.41-1.41L2.1,2.1z M16,20H8v-3.5l2.84-2.84L16,18.83 V20z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

