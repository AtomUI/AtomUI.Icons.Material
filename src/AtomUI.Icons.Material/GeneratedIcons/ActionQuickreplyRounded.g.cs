// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionQuickreplyRounded : MaterialIcon
{
    public ActionQuickreplyRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 2, 20.300000000000001, 20.290000000000003);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1059907834101383, 0, 0, 1.1059907834101383, -1.2718894009216601, -1.2718894009216601);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,4c0-1.1-0.9-2-2-2H4C2.9,2,2.01,2.9,2.01,4L2,22l4-4h9v-7c0-0.55,0.45-1,1-1h6V4z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21.69,16H20.3l1.4-3.3c0.14-0.33-0.1-0.7-0.46-0.7H17.5c-0.28,0-0.5,0.22-0.5,0.5v5c0,0.28,0.22,0.5,0.5,0.5H19v3.94 c0,0.26,0.36,0.35,0.47,0.11l2.66-5.33C22.3,16.39,22.06,16,21.69,16z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

