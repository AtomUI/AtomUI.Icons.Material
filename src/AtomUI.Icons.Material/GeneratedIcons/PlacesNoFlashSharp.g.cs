// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesNoFlashSharp : MaterialIcon
{
    public PlacesNoFlashSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.04, 2, 20.960000000000001, 20.959999999999997);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0452961672473868, 0, 0, 1.0452961672473868, -0.54355400696864109, -0.54355400696864109);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.45,2.45L1.04,3.87l5.3,5.3L6.14,9.4H2V22h16v-1.17l2.13,2.13l1.41-1.41L2.45,2.45z M10,20c-2.21,0-4-1.79-4-4 c0-1.95,1.4-3.57,3.25-3.92l1.57,1.57c-0.26-0.09-0.53-0.15-0.82-0.15c-1.38,0-2.5,1.12-2.5,2.5c0,1.38,1.12,2.5,2.5,2.5 c1.38,0,2.5-1.12,2.5-2.5c0-0.29-0.06-0.56-0.15-0.82l1.57,1.57C13.57,18.6,11.95,20,10,20z M18,15.17L10.83,8h1.75l1.28,1.4H18 V15.17z M20.4,5.6H22L19,11V7h-1V2h4L20.4,5.6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

