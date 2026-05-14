// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageCurrencyBitcoinRounded : MaterialIcon
{
    public ImageCurrencyBitcoinRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 3, 13, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M10,7h4c1.1,0,2,0.9,2,2s-0.9,2-2,2h-4V7z M15,17h-5v-4h5c1.1,0,2,0.9,2,2S16.1,17,15,17z M15,4c0-0.55-0.45-1-1-1 s-1,0.45-1,1v1h-2V4c0-0.55-0.45-1-1-1S9,3.45,9,4v1H7C6.45,5,6,5.45,6,6s0.45,1,1,1h1v10H7c-0.55,0-1,0.45-1,1s0.45,1,1,1h2v1 c0,0.55,0.45,1,1,1s1-0.45,1-1v-1h2v1c0,0.55,0.45,1,1,1s1-0.45,1-1v-1c2.21,0,4-1.79,4-4c0-1.45-0.78-2.73-1.94-3.43 C17.65,10.88,18,9.98,18,9c0-1.86-1.27-3.43-3-3.87L15,4z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

