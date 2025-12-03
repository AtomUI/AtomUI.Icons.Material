// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionInstallDesktopTwoTone : Icon
{
    public ActionInstallDesktopTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(14.83, 9),new Point(14.83, 9),new Point(16, 10.17)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(4, 17),new Point(20, 17),new Point(20, 13.83),new Point(17, 16.83),new Point(9.17, 9),new Point(13, 5.17),new Point(13, 5),new Point(4, 5)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,17H4V5h9V3H4C2.89,3,2,3.89,2,5v12c0,1.1,0.89,2,2,2h4v2h8v-2h4c1.1,0,2-0.9,2-2v-5.17l-2,2V17z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(18, 10.17),new Point(18, 3),new Point(16, 3),new Point(16, 10.17),new Point(13.41, 7.59),new Point(12, 9),new Point(17, 14),new Point(22, 9),new Point(20.59, 7.59)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

