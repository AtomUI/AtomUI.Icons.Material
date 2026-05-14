// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesCarpenterSharp : MaterialIcon
{
    public PlacesCarpenterSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.1099999999999999, 1.5, 18.030000000000001, 21.210000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0767160161507403, 0, 0, 1.0767160161507403, -0.9205921938088828, -0.9205921938088828);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M7,1.5L3.11,5.39l8.13,11.67l-1.41,1.41l4.24,4.24l7.07-7.07L7,1.5z M12.66,18.47l4.24-4.24l1.41,1.41l-4.24,4.24 L12.66,18.47z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

