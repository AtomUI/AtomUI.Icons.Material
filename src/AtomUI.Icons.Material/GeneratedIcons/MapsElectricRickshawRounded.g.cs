// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsElectricRickshawRounded : MaterialIcon
{
    public MapsElectricRickshawRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 3, 22.009999999999998, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0439321444106133, 0, 0, 1.0439321444106133, -0.52718573292736082, -0.52718573292736082);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21,11.18V9.72c0-0.47-0.16-0.92-0.46-1.28L16.6,3.72C16.22,3.26,15.66,3,15.06,3H3C1.9,3,1,3.9,1,5v8c0,1.1,0.9,2,2,2 h0.18C3.6,16.16,4.7,17,6,17s2.4-0.84,2.82-2h8.37c0.41,1.16,1.51,2,2.82,2c1.66,0,3-1.34,3-3C23,12.7,22.16,11.6,21,11.18z M18.4,9H16V6.12L18.4,9z M4,5h3v4H3V6C3,5.45,3.45,5,4,5z M6,15c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1S6.55,15,6,15z M9,13v-2 h2c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H9V5h4c0.55,0,1,0.45,1,1v7H9z M20,15c-0.55,0-1-0.45-1-1s0.45-1,1-1s1,0.45,1,1 S20.55,15,20,15z"),
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

