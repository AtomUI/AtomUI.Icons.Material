// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SearchCoffeeMakerRounded : MaterialIcon
{
    public SearchCoffeeMakerRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 2, 16, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,6V4h1c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H6C4.9,2,4,2.9,4,4v16c0,1.1,0.9,2,2,2h13c0.55,0,1-0.45,1-1v0 c0-0.55-0.45-1-1-1h-3.03C17.2,19.09,18,17.64,18,16v-3c0-1.1-0.9-2-2-2h-6c-1.1,0-2,0.9-2,2v3c0,1.64,0.81,3.09,2.03,4H6V4h2v2 c0,0.55,0.45,1,1,1h8C17.55,7,18,6.55,18,6z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(13, 9),
            Radius = 1
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

