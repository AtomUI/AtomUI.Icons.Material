// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionMarkAsUnreadSharp : Icon
{
    public ActionMarkAsUnreadSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(16.23, 7),new Point(20.35, 7),new Point(10.5, 2),new Point(2, 6.21),new Point(2, 17),new Point(4, 17),new Point(4, 7.4),new Point(10.5, 4)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5,8v13h17V8H5z M20,12l-6.5,3.33L7,12v-2l6.5,3.33L20,10V12z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

