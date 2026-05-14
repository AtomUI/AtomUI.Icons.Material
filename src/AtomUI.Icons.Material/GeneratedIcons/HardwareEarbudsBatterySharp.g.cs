// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareEarbudsBatterySharp : MaterialIcon
{
    public HardwareEarbudsBatterySharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 6, 20, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(20, 7),new Avalonia.Point(20, 6),new Avalonia.Point(18, 6),new Avalonia.Point(18, 7),new Avalonia.Point(16, 7),new Avalonia.Point(16, 18),new Avalonia.Point(22, 18),new Avalonia.Point(22, 7)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5.38,16.5L5.38,16.5c-1.04,0-1.88-0.84-1.88-1.87V10H6V6H4C2.9,6,2,6.9,2,8v6.63C2,16.49,3.51,18,5.37,18h0 c1.86,0,3.37-1.51,3.37-3.37V9.37c0-1.04,0.84-1.87,1.87-1.87h0c1.04,0,1.87,0.84,1.87,1.87V14H10v4h2c1.1,0,2-0.9,2-2V9.37 C14,7.51,12.49,6,10.63,6h0C8.76,6,7.25,7.51,7.25,9.37v5.25C7.25,15.66,6.41,16.5,5.38,16.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

