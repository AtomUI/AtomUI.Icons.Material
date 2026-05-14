// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionEcoRounded : MaterialIcon
{
    public ActionEcoRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.3199999999999998, 4.009999999999998, 16.66, 16.540000000000003);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1605415860735009, 0, 0, 1.1605415860735009, -1.9264990328820097, -1.9264990328820097);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6.05,8.05c-2.73,2.73-2.73,7.15-0.02,9.88c1.47-3.4,4.09-6.24,7.36-7.93c-2.77,2.34-4.71,5.61-5.39,9.32 c2.6,1.23,5.8,0.78,7.95-1.37c2.99-2.99,3.83-11.14,4.01-13.38c0.02-0.31-0.23-0.56-0.53-0.53C17.19,4.22,9.04,5.06,6.05,8.05z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

