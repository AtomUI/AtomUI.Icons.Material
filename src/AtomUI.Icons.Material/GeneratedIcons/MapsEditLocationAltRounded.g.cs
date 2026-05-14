// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsEditLocationAltRounded : MaterialIcon
{
    public MapsEditLocationAltRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 0.90000000000000002, 17.100000000000001, 20.850000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0389610389610391, 0, 0, 1.0389610389610391, -0.46753246753246813, -0.46753246753246813);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13.54,13H10c-0.55,0-1-0.45-1-1V8.46C9,8.2,9.11,7.94,9.29,7.76l5.32-5.32C13.78,2.16,12.9,2,12,2c-4.2,0-8,3.22-8,8.2 c0,3.18,2.44,6.92,7.33,11.22c0.38,0.33,0.96,0.33,1.34,0C17.56,17.12,20,13.37,20,10.2c0-1.01-0.16-1.94-0.45-2.8l-5.31,5.31 C14.06,12.89,13.8,13,13.54,13z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(11, 11),new Avalonia.Point(13.12, 11),new Avalonia.Point(19.28, 4.84),new Avalonia.Point(17.16, 2.72),new Avalonia.Point(11, 8.88)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20.71,2L20,1.29c-0.39-0.39-1.02-0.39-1.41,0l-0.72,0.72l2.12,2.12l0.72-0.72C21.1,3.02,21.1,2.39,20.71,2z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

