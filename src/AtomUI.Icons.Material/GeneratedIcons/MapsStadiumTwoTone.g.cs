// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsStadiumTwoTone : MaterialIcon
{
    public MapsStadiumTwoTone()
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
            Data = StreamGeometry.Parse("M5,10.04C6.38,10.53,8.77,11,12,11s5.62-0.47,7-0.96C19,9.86,16.22,9,12,9S5,9.86,5,10.04z M20,11.8 c-1.82,0.73-4.73,1.2-8,1.2s-6.18-0.47-8-1.2v6.78c0.61,0.41,2.36,1.01,5,1.28V16h6v3.86c2.64-0.27,4.39-0.87,5-1.28V11.8z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M7,5L3,7V3L7,5z M18,3v4l4-2L18,3z M11,2v4l4-2L11,2z M13,18h-2l0,4c-5.05-0.15-9-1.44-9-3v-9c0-1.66,4.48-3,10-3 s10,1.34,10,3v9c0,1.56-3.95,2.85-9,3L13,18z M5,10.04C6.38,10.53,8.77,11,12,11s5.62-0.47,7-0.96C19,9.86,16.22,9,12,9 S5,9.86,5,10.04z M20,11.8c-1.82,0.73-4.73,1.2-8,1.2s-6.18-0.47-8-1.2v6.78c0.61,0.41,2.36,1.01,5,1.28V16h6v3.86 c2.64-0.27,4.39-0.87,5-1.28V11.8z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

