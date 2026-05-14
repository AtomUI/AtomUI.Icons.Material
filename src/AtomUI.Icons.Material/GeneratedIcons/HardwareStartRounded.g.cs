// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareStartRounded : MaterialIcon
{
    public HardwareStartRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 6, 19.68, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15.29,17.29c0.39,0.39,1.02,0.39,1.41,0l4.59-4.59c0.39-0.39,0.39-1.02,0-1.41L16.7,6.7c-0.39-0.39-1.02-0.39-1.41,0 c-0.38,0.39-0.39,1.03,0,1.42L18.17,11H7c-0.55,0-1,0.45-1,1s0.45,1,1,1h11.17l-2.88,2.88C14.9,16.27,14.9,16.9,15.29,17.29z M3,18 c0.55,0,1-0.45,1-1V7c0-0.55-0.45-1-1-1S2,6.45,2,7v10C2,17.55,2.45,18,3,18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

