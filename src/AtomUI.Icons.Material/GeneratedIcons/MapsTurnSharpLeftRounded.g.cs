// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsTurnSharpLeftRounded : MaterialIcon
{
    public MapsTurnSharpLeftRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.3199999999999998, 3.3199999999999998, 14.68, 17.68);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1787819253438114, 0, 0, 1.1787819253438114, -2.1453831041257381, -2.1453831041257381);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M8,6.83l0.88,0.88c0.39,0.39,1.02,0.39,1.41,0c0.39-0.39,0.39-1.02,0-1.41L7.71,3.71c-0.39-0.39-1.02-0.39-1.41,0 L3.71,6.29c-0.39,0.39-0.39,1.02,0,1.41c0.39,0.39,1.02,0.39,1.41,0L6,6.83V13c0,1.1,0.9,2,2,2h8v5c0,0.55,0.45,1,1,1h0 c0.55,0,1-0.45,1-1v-5c0-1.1-0.9-2-2-2H8V6.83L8,6.83z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

