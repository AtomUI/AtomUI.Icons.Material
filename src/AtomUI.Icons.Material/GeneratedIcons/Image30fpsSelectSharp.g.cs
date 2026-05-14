// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class Image30fpsSelectSharp : MaterialIcon
{
    public Image30fpsSelectSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 4, 18, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M4,4v2h5v2H5v2h4v2H4v2h7V4H4z M13,4h7v10h-7V4z M18,6h-3v6h3V6z M5,22H3v-5h2V22z M9,22H7v-5h2V22z M13,22h-2v-5h2V22z M21,22h-6v-5h6V22z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

