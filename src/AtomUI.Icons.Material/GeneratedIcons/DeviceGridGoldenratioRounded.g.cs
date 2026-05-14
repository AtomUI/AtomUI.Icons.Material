// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceGridGoldenratioRounded : MaterialIcon
{
    public DeviceGridGoldenratioRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 2, 20, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21,13h-6v-2h6c0.55,0,1-0.45,1-1s-0.45-1-1-1h-6V3c0-0.55-0.45-1-1-1s-1,0.45-1,1v6h-2V3c0-0.55-0.45-1-1-1S9,2.45,9,3v6 H3c-0.55,0-1,0.45-1,1s0.45,1,1,1h6v2H3c-0.55,0-1,0.45-1,1s0.45,1,1,1h6v6c0,0.55,0.45,1,1,1s1-0.45,1-1v-6h2v6c0,0.55,0.45,1,1,1 s1-0.45,1-1v-6h6c0.55,0,1-0.45,1-1S21.55,13,21,13z M13,13h-2v-2h2V13z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

