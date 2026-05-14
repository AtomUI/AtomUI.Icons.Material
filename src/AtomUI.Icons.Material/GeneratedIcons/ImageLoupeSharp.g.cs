// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageLoupeSharp : MaterialIcon
{
    public ImageLoupeSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5899999999999999, 1.5900000000000003, 20.41, 20.41);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.07095046854083, 0, 0, 1.07095046854083, -0.85140562248995977, -0.85140562248995977);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13 7h-2v4H7v2h4v4h2v-4h4v-2h-4V7zm-.27-4.97c-6.08-.44-11.14 4.62-10.7 10.7.38 5.28 5 9.27 10.29 9.27H22v-9.68c0-5.3-3.98-9.91-9.27-10.29zM12 20c-4.41 0-8-3.59-8-8s3.59-8 8-8 8 3.59 8 8-3.59 8-8 8z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

