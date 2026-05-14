// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionTabSharp : MaterialIcon
{
    public ActionTabSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 1024, 1024);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 1024, 1024);
    internal override Rect GeneratedGeometryBounds => new Rect(85.333332999999996, 128, 853.33333400000004, 768);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090905216943, 0, 0, 1.0909090905216943, -46.545454347107466, -46.545454347107466);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M85.333333 128h853.333334v768H85.333333V128z m85.333334 85.333333v597.333334h682.666666V384h-341.333333V213.333333H170.666667z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

