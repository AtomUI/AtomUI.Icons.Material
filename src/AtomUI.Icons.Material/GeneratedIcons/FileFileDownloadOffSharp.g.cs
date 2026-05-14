// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class FileFileDownloadOffSharp : MaterialIcon
{
    public FileFileDownloadOffSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.3899999999999999, 2.8100000000000001, 19.800000000000001, 19.800000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0614772224679345, 0, 0, 1.0614772224679345, -0.73772666961521338, -0.73772666961521338);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M9,6.17V3h6v6h4l-3.59,3.59L9,6.17z M21.19,21.19L2.81,2.81L1.39,4.22L6.17,9H5l7,7l0.59-0.59L15.17,18H5v2h12.17l2.61,2.61 L21.19,21.19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

