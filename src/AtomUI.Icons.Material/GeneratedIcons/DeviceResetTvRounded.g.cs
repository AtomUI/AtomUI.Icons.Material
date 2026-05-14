// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceResetTvRounded : MaterialIcon
{
    public DeviceResetTvRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 3, 20, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,10h-7.01V8.21c0-0.45-0.54-0.67-0.85-0.35l-2.78,2.79c-0.19,0.2-0.19,0.51,0,0.71l2.78,2.79 c0.31,0.32,0.85,0.09,0.85-0.35V12H20v5H4V5h16v2c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1l0-2c0-1.1-0.9-2-2-2H4C2.9,3,2,3.9,2,5v12 c0,1.1,0.9,2,2,2h4v1c0,0.55,0.45,1,1,1h6c0.55,0,1-0.45,1-1v-1h4c1.1,0,2-0.9,2-2v-5C22,10.9,21.1,10,20,10z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

