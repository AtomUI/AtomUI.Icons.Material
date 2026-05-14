// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsTurnSlightRightRounded : MaterialIcon
{
    public MapsTurnSlightRightRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(9, 4, 9, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12.34,5L12.34,5c0-0.55,0.45-1,1-1H17c0.55,0,1,0.45,1,1v3.66c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1V7.41l-5,5V19 c0,0.55-0.45,1-1,1h0c-0.55,0-1-0.45-1-1v-6.58c0-0.53,0.21-1.04,0.59-1.41l5-5h-1.24C12.79,6,12.34,5.55,12.34,5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

