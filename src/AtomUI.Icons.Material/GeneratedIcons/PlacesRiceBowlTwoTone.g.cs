// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesRiceBowlTwoTone : MaterialIcon
{
    public PlacesRiceBowlTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 2, 20, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19.66,14c-0.66,1.92-2.24,3.54-4.4,4.39L14,18.88V20h-4v-1.12l-1.27-0.5c-2.16-0.85-3.74-2.47-4.4-4.39 H19.66"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19.66,14c-0.66,1.92-2.24,3.54-4.4,4.39L14,18.88V20h-4v-1.12l-1.27-0.5c-2.16-0.85-3.74-2.47-4.4-4.39H19.66 M12,2 C6.48,2,2,6.48,2,12c0,3.69,2.47,6.86,6,8.25V22h8v-1.75c3.53-1.39,6-4.56,6-8.25h0C22,6.48,17.52,2,12,2L12,2z M10,12V4.26 C10.64,4.1,11.31,4,12,4s1.36,0.1,2,0.26V12H10L10,12z M16,12V5.08c2.39,1.39,4,3.96,4,6.92H16L16,12z M4,12 c0-2.95,1.61-5.53,4-6.92V12H4L4,12z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

