// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionSavedSearchRounded : MaterialIcon
{
    public ActionSavedSearchRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.2000000000000002, 2.2000000000000002, 18.48, 18.48);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1009174311926606, 0, 0, 1.1009174311926606, -1.2110091743119273, -1.2110091743119273);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M14.73,13.31c1.13-1.55,1.63-3.58,0.98-5.74c-0.68-2.23-2.57-3.98-4.85-4.44C6.21,2.2,2.2,6.22,3.14,10.86 c0.46,2.29,2.21,4.18,4.44,4.85c2.16,0.65,4.19,0.15,5.74-0.98l5.56,5.56c0.39,0.39,1.02,0.39,1.41,0l0,0 c0.39-0.39,0.39-1.02,0-1.41L14.73,13.31z M9.5,14C7.01,14,5,11.99,5,9.5S7.01,5,9.5,5S14,7.01,14,9.5S11.99,14,9.5,14z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(10.29, 8.44),new Avalonia.Point(9.5, 6),new Avalonia.Point(8.71, 8.44),new Avalonia.Point(6.25, 8.44),new Avalonia.Point(8.26, 10.03),new Avalonia.Point(7.49, 12.5),new Avalonia.Point(9.5, 10.97),new Avalonia.Point(11.51, 12.5),new Avalonia.Point(10.74, 10.03),new Avalonia.Point(12.75, 8.44)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

