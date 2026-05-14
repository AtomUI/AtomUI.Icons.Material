// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialSingleBedRounded : MaterialIcon
{
    public SocialSingleBedRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 5, 16, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,10V7c0-1.1-0.9-2-2-2H8C6.9,5,6,5.9,6,7v3c-1.1,0-2,0.9-2,2v5h1.33l0.51,1.53C5.94,18.81,6.2,19,6.5,19h0 c0.3,0,0.56-0.19,0.66-0.47L7.67,17h8.67l0.51,1.53C16.94,18.81,17.2,19,17.5,19l0,0c0.3,0,0.56-0.19,0.66-0.47L18.67,17H20v-5 C20,10.9,19.1,10,18,10z M11,10H8V8c0-0.55,0.45-1,1-1h2V10z M16,10h-3V7h2c0.55,0,1,0.45,1,1V10z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

