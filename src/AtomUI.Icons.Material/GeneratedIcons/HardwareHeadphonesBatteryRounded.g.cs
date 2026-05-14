// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareHeadphonesBatteryRounded : MaterialIcon
{
    public HardwareHeadphonesBatteryRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 6, 20, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21,7h-1V6.5C20,6.22,19.78,6,19.5,6h-1C18.22,6,18,6.22,18,6.5V7h-1c-0.55,0-1,0.45-1,1v9c0,0.55,0.45,1,1,1h4 c0.55,0,1-0.45,1-1V8C22,7.45,21.55,7,21,7z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M8,6c-3.31,0-6,2.69-6,6v4c0,1.1,0.9,2,2,2s2-0.9,2-2v-1c0-1.1-0.9-2-2-2H3.5v-1c0-2.48,2.02-4.5,4.5-4.5 s4.5,2.02,4.5,4.5v1H12c-1.1,0-2,0.9-2,2v1c0,1.1,0.9,2,2,2s2-0.9,2-2v-4C14,8.69,11.31,6,8,6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

