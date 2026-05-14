// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesNoFoodSharp : MaterialIcon
{
    public PlacesNoFoodSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.68999999999999995, 1, 22.309999999999999, 22.32);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0300429184549356, 0, 0, 1.0300429184549356, -0.36051502145922676, -0.36051502145922676);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M11.35,8.52L11,5h5V1h2v4h5l-1.38,13.79L18,15.17L11.35,8.52z M21.9,21.9L2.1,2.1L0.69,3.51l5.7,5.7 C3.46,9.83,1,11.76,1,15h11.17l2,2H1v2h15v-0.17l4.49,4.49L21.9,21.9z M1,23h15v-2H1V23z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

