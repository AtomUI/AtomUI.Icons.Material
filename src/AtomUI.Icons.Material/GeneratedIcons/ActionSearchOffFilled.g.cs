// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionSearchOffFilled : MaterialIcon
{
    public ActionSearchOffFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.81999999999999995, 3, 19.669999999999998, 17.490000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0353753235547887, 0, 0, 1.0353753235547887, -0.42450388265746497, -0.42450388265746497);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15.5,14h-0.79l-0.28-0.27C15.41,12.59,16,11.11,16,9.5C16,5.91,13.09,3,9.5,3C6.08,3,3.28,5.64,3.03,9h2.02 C5.3,6.75,7.18,5,9.5,5C11.99,5,14,7.01,14,9.5S11.99,14,9.5,14c-0.17,0-0.33-0.03-0.5-0.05v2.02C9.17,15.99,9.33,16,9.5,16 c1.61,0,3.09-0.59,4.23-1.57L14,14.71v0.79l5,4.99L20.49,19L15.5,14z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6.47, 10.82),new Avalonia.Point(4, 13.29),new Avalonia.Point(1.53, 10.82),new Avalonia.Point(0.82, 11.53),new Avalonia.Point(3.29, 14),new Avalonia.Point(0.82, 16.47),new Avalonia.Point(1.53, 17.18),new Avalonia.Point(4, 14.71),new Avalonia.Point(6.47, 17.18),new Avalonia.Point(7.18, 16.47),new Avalonia.Point(4.71, 14),new Avalonia.Point(7.18, 11.53)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

