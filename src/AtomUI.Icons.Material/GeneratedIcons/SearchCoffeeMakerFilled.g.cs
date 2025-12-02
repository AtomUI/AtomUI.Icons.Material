// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class SearchCoffeeMakerFilled : Icon
{
    public SearchCoffeeMakerFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,6V4h2V2H6C4.9,2,4,2.9,4,4v16c0,1.1,0.9,2,2,2h14v-2h-4.03C17.2,19.09,18,17.64,18,16v-5H8v5c0,1.64,0.81,3.09,2.03,4 H6V4h2v2c0,0.55,0.45,1,1,1h8C17.55,7,18,6.55,18,6z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Point(13, 9),
            Radius = 1
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

