// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesRoofingRounded : MaterialIcon
{
    public PlacesRoofingRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.6299999999999999, 3.2599999999999998, 18.739999999999998, 16.740000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1230697239120262, 0, 0, 1.1230697239120262, -1.4768366869443135, -1.4768366869443135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13,18h-2v-2h2V18z M9,15v4c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1v-4c0-0.55-0.45-1-1-1h-4C9.45,14,9,14.45,9,15z M19,9.3 L19,9.3V5c0-0.55-0.45-1-1-1h-1c-0.55,0-1,0.45-1,1v1.6v0l-3.33-3c-0.38-0.34-0.96-0.34-1.34,0l-8.36,7.53 C2.63,11.43,2.84,12,3.3,12h1.31c0.25,0,0.49-0.09,0.67-0.26L12,5.69l6.71,6.05C18.9,11.91,19.14,12,19.38,12h1.31 c0.46,0,0.68-0.57,0.33-0.87L19,9.3z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

