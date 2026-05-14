// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesNoDrinksRounded : MaterialIcon
{
    public PlacesNoDrinksRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.7099999999999995, 3, 19.289999999999999, 19.290000000000003);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0767160161507403, 0, 0, 1.0767160161507403, -0.9205921938088828, -0.9205921938088828);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20.49,20.49L3.51,3.51c-0.39-0.39-1.02-0.39-1.41,0c-0.39,0.39-0.39,1.02,0,1.41l7.54,7.54L11,14v5H7c-0.55,0-1,0.45-1,1 s0.45,1,1,1h10c0.32,0,0.59-0.16,0.78-0.4l1.3,1.3c0.39,0.39,1.02,0.39,1.41,0C20.88,21.51,20.88,20.88,20.49,20.49z M13,19v-3.17 L16.17,19H13z M7.83,5l-2-2h13.72C20.35,3,21,3.65,21,4.45c0,0.35-0.13,0.7-0.37,0.96l-5.83,6.56L9.83,7h6.74l1.78-2H7.83z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

