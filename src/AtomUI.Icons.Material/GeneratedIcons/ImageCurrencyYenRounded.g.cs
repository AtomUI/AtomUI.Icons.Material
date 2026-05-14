// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageCurrencyYenRounded : MaterialIcon
{
    public ImageCurrencyYenRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5.5499999999999998, 3, 12.899999999999999, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6.82,3c0.34,0,0.66,0.17,0.84,0.46L12,10.29l4.34-6.83C16.52,3.17,16.84,3,17.18,3c0.79,0,1.27,0.87,0.84,1.54L13.92,11 H17c0.55,0,1,0.45,1,1c0,0.55-0.45,1-1,1h-4v2h4c0.55,0,1,0.45,1,1c0,0.55-0.45,1-1,1h-4v3c0,0.55-0.45,1-1,1s-1-0.45-1-1v-3H7 c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1h4v-2H7c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1h3.08L5.98,4.54C5.55,3.87,6.03,3,6.82,3z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

