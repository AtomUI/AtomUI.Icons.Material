// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DevicePhishingRounded : MaterialIcon
{
    public DevicePhishingRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 2, 14, 19.420000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19,9c0-1.3-0.84-2.4-2-2.82V3c0-0.55-0.45-1-1-1h0c-0.55,0-1,0.45-1,1v3.18C13.84,6.6,13,7.7,13,9s0.84,2.4,2,2.82l0,3.01 c0,2.09-1.52,3.96-3.6,4.16C9.02,19.21,7,17.34,7,15v-1h1.79c0.45,0,0.67-0.54,0.35-0.85L5.85,9.85C5.54,9.54,5,9.76,5,10.21 l0,4.58c0,3.05,2.19,5.77,5.21,6.16C13.87,21.42,17,18.57,17,15v-3.18C18.16,11.4,19,10.3,19,9z M16,10c-0.55,0-1-0.45-1-1 s0.45-1,1-1s1,0.45,1,1S16.55,10,16,10z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

