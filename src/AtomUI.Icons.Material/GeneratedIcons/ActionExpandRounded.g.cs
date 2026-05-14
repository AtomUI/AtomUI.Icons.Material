// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionExpandRounded : MaterialIcon
{
    public ActionExpandRounded()
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
            Data = StreamGeometry.Parse("M5,20h14c0.55,0,1,0.45,1,1v0c0,0.55-0.45,1-1,1H5c-0.55,0-1-0.45-1-1v0C4,20.45,4.45,20,5,20z M5,2h14c0.55,0,1,0.45,1,1 v0c0,0.55-0.45,1-1,1H5C4.45,4,4,3.55,4,3v0C4,2.45,4.45,2,5,2z M13,9h1.79c0.45,0,0.67-0.54,0.35-0.85l-2.79-2.79 c-0.2-0.2-0.51-0.2-0.71,0L8.85,8.15C8.54,8.46,8.76,9,9.21,9H11v6H9.21c-0.45,0-0.67,0.54-0.35,0.85l2.79,2.79 c0.2,0.2,0.51,0.2,0.71,0l2.79-2.79c0.31-0.31,0.09-0.85-0.35-0.85H13V9z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

