// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialEmojiFlagsRounded : MaterialIcon
{
    public SocialEmojiFlagsRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 2, 16, 19);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19,9h-5l-0.72-1.45C13.11,7.21,12.76,7,12.38,7H7V5.72C7.6,5.38,8,4.74,8,4c0-1.1-0.9-2-2-2S4,2.9,4,4 c0,0.74,0.4,1.38,1,1.72V20c0,0.55,0.45,1,1,1s1-0.45,1-1v-3h5l0.72,1.45c0.17,0.34,0.52,0.55,0.89,0.55H19c0.55,0,1-0.45,1-1v-8 C20,9.45,19.55,9,19,9z M18,17h-4l-1-2H7V9h5l1,2h5V17z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

