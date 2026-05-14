// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ContentFontDownloadOffSharp : MaterialIcon
{
    public ContentFontDownloadOffSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.68999999999999995, 2, 21.309999999999999, 21.309999999999999);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0296010296010294, 0, 0, 1.0296010296010294, -0.35521235521235184, -0.35521235521235184);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12.58,9.75l-0.87-0.87l0.23-0.66h0.1L12.58,9.75z M20.49,23.31L19.17,22H2V4.83L0.69,3.51L2.1,2.1l19.8,19.8L20.49,23.31z M12.1,14.93l-3.3-3.3L6.41,18h2.08l1.09-3.07H12.1z M10.35,7.52L10.92,6h2.14l2.55,6.79L22,19.17V2H4.83L10.35,7.52z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

