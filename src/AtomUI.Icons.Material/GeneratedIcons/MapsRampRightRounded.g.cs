// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsRampRightRounded : MaterialIcon
{
    public MapsRampRightRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5.4400000000000004, 3.3199999999999998, 10.240000000000002, 17.68);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1787819253438114, 0, 0, 1.1787819253438114, -2.1453831041257381, -2.1453831041257381);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,21c0.55,0,1-0.45,1-1V6.83l0.88,0.88c0.39,0.39,1.02,0.39,1.41,0c0.39-0.39,0.39-1.02,0-1.41l-2.59-2.59 c-0.39-0.39-1.02-0.39-1.41,0L8.71,6.29c-0.39,0.39-0.39,1.02,0,1.41c0.39,0.39,1.02,0.39,1.41,0L11,6.83v0V9 c0,3.62-2.89,6.22-4.97,7.62c-0.52,0.35-0.59,1.09-0.14,1.53c0.33,0.33,0.87,0.4,1.26,0.13c1.59-1.06,2.89-2.28,3.85-3.59l0,5.3 C11,20.55,11.45,21,12,21z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

