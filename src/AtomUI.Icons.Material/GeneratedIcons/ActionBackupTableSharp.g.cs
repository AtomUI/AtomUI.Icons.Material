// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionBackupTableSharp : Icon
{
    public ActionBackupTableSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(20, 6),new Point(20, 20),new Point(6, 20),new Point(6, 22),new Point(22, 22),new Point(22, 6)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,2H2v16h16V2z M9,16H4v-5h5V16z M16,16h-5v-5h5V16z M16,9H4V4h12V9z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

