// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsMovingRounded : MaterialIcon
{
    public MapsMovingRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.3199999999999998, 6, 19.68, 11.68);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1235955056179776, 0, 0, 1.1235955056179776, -1.4831460674157313, -1.4831460674157313);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.7,17.29c0.39,0.39,1.02,0.39,1.41,0l4.59-4.59c0.39-0.39,1.02-0.39,1.41,0l1.17,1.17c1.17,1.17,3.07,1.17,4.24,0 l4.18-4.17l1.44,1.44c0.31,0.31,0.85,0.09,0.85-0.35V6.5C22,6.22,21.78,6,21.5,6h-4.29c-0.45,0-0.67,0.54-0.35,0.85l1.44,1.44 l-4.17,4.17c-0.39,0.39-1.02,0.39-1.41,0l-1.17-1.17c-1.17-1.17-3.07-1.17-4.24,0L2.7,15.88C2.32,16.27,2.32,16.91,2.7,17.29z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

