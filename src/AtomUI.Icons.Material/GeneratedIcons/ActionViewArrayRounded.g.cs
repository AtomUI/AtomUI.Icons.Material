// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionViewArrayRounded : MaterialIcon
{
    public ActionViewArrayRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 5, 18, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,5h-1c-0.55,0-1,0.45-1,1v12c0,0.55,0.45,1,1,1h1c0.55,0,1-0.45,1-1V6C21,5.45,20.55,5,20,5z M16,5H8C7.45,5,7,5.45,7,6 v12c0,0.55,0.45,1,1,1h8c0.55,0,1-0.45,1-1V6C17,5.45,16.55,5,16,5z M5,5H4C3.45,5,3,5.45,3,6v12c0,0.55,0.45,1,1,1h1 c0.55,0,1-0.45,1-1V6C6,5.45,5.55,5,5,5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

