// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionOutputRounded : MaterialIcon
{
    public ActionOutputRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18.690000000000001, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1816838995568686, 0, 0, 1.1816838995568686, -2.1802067946824231, -2.1802067946824231);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M17.71,16.29l3.59-3.59c0.39-0.39,0.39-1.02,0-1.41l-3.59-3.59c-0.39-0.39-1.02-0.39-1.41,0v0 c-0.39,0.39-0.39,1.02,0,1.41L18.17,11H10c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h8.17l-1.88,1.88c-0.39,0.39-0.39,1.02,0,1.41 l0,0C16.68,16.68,17.32,16.68,17.71,16.29z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19,19H5V5h14v1c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V5c0-1.1-0.9-2-2-2H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14 c1.11,0,2-0.9,2-2v-1c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1V19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
