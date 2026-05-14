// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageImageNotSupportedSharp : MaterialIcon
{
    public ImageImageNotSupportedSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.68999999999999995, 2.1000000000000001, 21.209999999999997, 21.209999999999997);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0296010296010294, 0, 0, 1.0296010296010294, -0.35521235521235184, -0.35521235521235184);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21.9,21.9l-8.49-8.49l0,0L3,3l0,0L2.1,2.1L0.69,3.51L3,5.83V21h15.17l2.31,2.31L21.9,21.9z M5,18l3.5-4.5l2.5,3.01 L12.17,15l3,3H5z M21,18.17L5.83,3H21V18.17z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

