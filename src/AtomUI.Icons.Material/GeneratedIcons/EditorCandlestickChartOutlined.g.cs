// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class EditorCandlestickChartOutlined : Icon
{
    public EditorCandlestickChartOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M9,4H7v2H5v12h2v2h2v-2h2V6H9V4z M9,16H7V8h2V16z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19,8h-2V4h-2v4h-2v7h2v5h2v-5h2V8z M17,13h-2v-3h2V13z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

