// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class NavigationSouthEastRounded : MaterialIcon
{
    public NavigationSouthEastRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4.3200000000000003, 4.3100000000000005, 14.68, 14.69);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.218892839004571, 0, 0, 1.218892839004571, -2.6267140680548522, -2.6267140680548522);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,9L18,9c-0.56,0-1,0.45-1,1v5.59L6.12,4.7c-0.39-0.39-1.02-0.39-1.41,0l0,0c-0.39,0.39-0.39,1.02,0,1.41L15.59,17H10 c-0.55,0-1,0.45-1,1V18c0,0.55,0.45,1,1,1H18c0.55,0,1-0.45,1-1V10C19,9.45,18.55,9,18,9z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

