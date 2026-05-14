// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SearchCoffeeSharp : MaterialIcon
{
    public SearchCoffeeSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 3, 18.390000000000001, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2238653748087711, 0, 0, 1.2238653748087711, -2.6863844977052533, -2.6863844977052533);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18.5,3H4v8c0,3.87,3.13,7,7,7h0c3.87,0,7-3.13,7-7v-1l0.4,0c1.67,0,3.19-1.13,3.52-2.77C22.39,4.98,20.67,3,18.5,3z M16,5 v3H6V5H16z M18.5,8H18V5h0.5C19.33,5,20,5.67,20,6.5S19.33,8,18.5,8z M4,19h16v2H4V19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

