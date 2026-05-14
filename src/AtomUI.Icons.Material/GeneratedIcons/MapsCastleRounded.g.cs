// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsCastleRounded : MaterialIcon
{
    public MapsCastleRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 3, 22, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,9c-0.55,0-1,0.45-1,1v1h-2V4c0-0.55-0.45-1-1-1s-1,0.45-1,1v1h-2V4c0-0.55-0.45-1-1-1s-1,0.45-1,1v1h-2V4 c0-0.55-0.45-1-1-1S9,3.45,9,4v1H7V4c0-0.55-0.45-1-1-1S5,3.45,5,4v7H3v-1c0-0.55-0.45-1-1-1s-1,0.45-1,1v9c0,1.1,0.9,2,2,2h7v-3 c0-1.1,0.9-2,2-2s2,0.9,2,2v3h7c1.1,0,2-0.9,2-2v-9C23,9.45,22.55,9,22,9z M11,12H9V9h2V12z M15,12h-2V9h2V12z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

