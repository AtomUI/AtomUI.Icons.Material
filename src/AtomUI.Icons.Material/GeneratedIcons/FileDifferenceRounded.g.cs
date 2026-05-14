// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class FileDifferenceRounded : MaterialIcon
{
    public FileDifferenceRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 1, 19, 22);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M3,7c0.55,0,1,0.45,1,1v13h13c0.55,0,1,0.45,1,1s-0.45,1-1,1H4c-1.1,0-2-0.9-2-2V8C2,7.45,2.45,7,3,7z M15.59,1.59 C15.21,1.21,14.7,1,14.17,1H8C6.9,1,6.01,1.9,6.01,3L6,17c0,1.1,0.89,2,1.99,2H19c1.1,0,2-0.9,2-2V7.83c0-0.53-0.21-1.04-0.59-1.41 L15.59,1.59z M15.5,15h-4c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h4c0.55,0,1,0.45,1,1v0C16.5,14.55,16.05,15,15.5,15z M15.5,9h-1 v1c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1V9h-1c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h1V6c0-0.55,0.45-1,1-1h0 c0.55,0,1,0.45,1,1v1h1c0.55,0,1,0.45,1,1v0C16.5,8.55,16.05,9,15.5,9z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

