// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsForkLeftRounded : MaterialIcon
{
    public MapsForkLeftRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4.3200000000000012, 3.319999999999999, 13.369999999999997, 17.68);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1787819253438112, 0, 0, 1.1787819253438112, -2.1453831041257345, -2.1453831041257345);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15,20c0,0.55-0.45,1-1,1c-0.55,0-1-0.45-1-1v-3c-0.73-2.58-3.07-3.47-5.17-3l0.88,0.88c0.39,0.39,0.39,1.02,0,1.41 c-0.39,0.39-1.02,0.39-1.41,0l-2.59-2.59c-0.39-0.39-0.39-1.02,0-1.41l2.59-2.59c0.39-0.39,1.02-0.39,1.41,0 c0.39,0.39,0.39,1.02,0,1.41L7.83,12c1.51-0.33,3.73,0.08,5.17,1.36l0-6.53l-0.88,0.88c-0.39,0.39-1.02,0.39-1.41,0 c-0.39-0.39-0.39-1.02,0-1.41l2.59-2.59c0.39-0.39,1.02-0.39,1.41,0l2.59,2.59c0.39,0.39,0.39,1.02,0,1.41 c-0.39,0.39-1.02,0.39-1.41,0L15,6.83V20z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

