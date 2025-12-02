// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionLoyaltyOutlined : Icon
{
    public ActionLoyaltyOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M21.41 11.58l-9-9C12.05 2.22 11.55 2 11 2H4c-1.1 0-2 .9-2 2v7c0 .55.22 1.05.59 1.42l9 9c.36.36.86.58 1.41.58s1.05-.22 1.41-.59l7-7c.37-.36.59-.86.59-1.41s-.23-1.06-.59-1.42zM13 20.01L4 11V4h7v-.01l9 9-7 7.02z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Center = new Point(6.5, 6.5),
            Radius = 1.5
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M8.9 12.55c0 .57.23 1.07.6 1.45l3.5 3.5 3.5-3.5c.37-.37.6-.89.6-1.45 0-1.13-.92-2.05-2.05-2.05-.57 0-1.08.23-1.45.6l-.6.6-.6-.59c-.37-.38-.89-.61-1.45-.61-1.13 0-2.05.92-2.05 2.05z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

