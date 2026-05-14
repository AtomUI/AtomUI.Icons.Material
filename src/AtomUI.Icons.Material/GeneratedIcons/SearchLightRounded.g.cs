// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SearchLightRounded : MaterialIcon
{
    public SearchLightRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13,6.06V4c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v2.06c-4.5,0.5-8,4.31-8,8.93C3,16.1,3.9,17,5.01,17L8,17 c0,2.21,1.79,4,4,4s4-1.79,4-4l2.99,0C20.1,17,21,16.1,21,14.99C21,10.37,17.5,6.56,13,6.06z M12,15l-7,0c0-3.86,3.14-7,7-7 s7,3.14,7,7L12,15z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

