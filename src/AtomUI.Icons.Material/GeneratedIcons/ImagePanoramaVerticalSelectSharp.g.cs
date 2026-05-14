// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImagePanoramaVerticalSelectSharp : MaterialIcon
{
    public ImagePanoramaVerticalSelectSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.5899999999999963, 1.9900000000000002, 16.82, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0904134484325307, 0, 0, 1.0904134484325307, -1.084961381190368, -1.084961381190368);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18.49,11.99c0-5.25,1.54-9.01,1.92-10l-16.82,0c0.76,2.16,1.9,5.21,1.9,10c0,4.78-1.17,7.91-1.9,10l16.81,0 C19.66,19.91,18.49,16.76,18.49,11.99z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

