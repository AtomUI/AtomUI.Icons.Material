// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImagePanoramaVerticalSelectOutlined : MaterialIcon
{
    public ImagePanoramaVerticalSelectOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.8399999999999999, 2, 16.330000000000002, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M18.5,12c0-3.89,0.84-6.95,1.43-8.69C20.15,2.67,19.67,2,18.98,2L5,2C4.32,2,3.84,2.66,4.05,3.31C4.74,5.36,5.5,8.1,5.5,12 c0,3.87-0.76,6.66-1.45,8.69C3.84,21.34,4.32,22,5,22h14c0.68,0,1.17-0.66,0.95-1.31C19.27,18.66,18.5,15.86,18.5,12z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

