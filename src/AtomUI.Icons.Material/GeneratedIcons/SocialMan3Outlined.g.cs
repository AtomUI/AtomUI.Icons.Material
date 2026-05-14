// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialMan3Outlined : MaterialIcon
{
    public SocialMan3Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(8, 1.7513219999999992, 8, 20.248678000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0787157780790391, 0, 0, 1.0787157780790391, -0.94458933694846792, -0.94458933694846792);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M14,7h-4C8.9,7,8,7.9,8,9v6h2v7h4v-7h2V9C16,7.9,15.1,7,14,7z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(10.41, 2.41, 3.18, 3.18),
            RadiusX = 0,
            RadiusY = 0,
            Transform = new Matrix(0.70709999999999995, 0.70709999999999995, -0.70709999999999995, 0.70709999999999995, 6.3430999999999997, -7.3136999999999999)
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

