// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialKingBedRounded : MaterialIcon
{
    public SocialKingBedRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 5, 20, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,10V7c0-1.1-0.9-2-2-2H6C4.9,5,4,5.9,4,7v3c-1.1,0-2,0.9-2,2v5h1.33l0.51,1.53C3.94,18.81,4.2,19,4.5,19h0 c0.3,0,0.56-0.19,0.66-0.47L5.67,17h12.67l0.51,1.53C18.94,18.81,19.2,19,19.5,19l0,0c0.3,0,0.56-0.19,0.66-0.47L20.67,17H22v-5 C22,10.9,21.1,10,20,10z M11,10H6V8c0-0.55,0.45-1,1-1h4V10z M18,10h-5V7h4c0.55,0,1,0.45,1,1V10z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

