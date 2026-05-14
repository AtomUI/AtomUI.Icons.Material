// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsElectricRickshawSharp : MaterialIcon
{
    public MapsElectricRickshawSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 3, 22.25, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.054945054945055, 0, 0, 1.054945054945055, -0.65934065934066055, -0.65934065934066055);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21,11.18V9l-5-6H1v12h2.18C3.6,16.16,4.7,17,6,17s2.4-0.84,2.82-2h8.37c0.48,1.34,1.86,2.25,3.42,1.94 c1.16-0.23,2.11-1.17,2.33-2.33C23.25,13.05,22.34,11.66,21,11.18z M18.4,9H16V6.12L18.4,9z M3,5h4v4H3V5z M6,15 c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S6.55,15,6,15z M9,13v-2h3V9H9V5h5v8H9z M20,15c-0.55,0-1-0.45-1-1s0.45-1,1-1 s1,0.45,1,1S20.55,15,20,15z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(7, 20),new Avalonia.Point(11, 20),new Avalonia.Point(11, 18),new Avalonia.Point(17, 21),new Avalonia.Point(13, 21),new Avalonia.Point(13, 23)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

