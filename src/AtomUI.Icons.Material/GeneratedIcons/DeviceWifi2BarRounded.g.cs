// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceWifi2BarRounded : MaterialIcon
{
    public DeviceWifi2BarRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4.75, 10, 14.500000000000004, 10);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2972972972972974, 0, 0, 1.2972972972972974, -3.5675675675675684, -3.5675675675675684);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,16c-1.1,0-2,0.9-2,2s0.9,2,2,2s2-0.9,2-2S13.1,16,12,16z M5.38,14.37c-0.63-0.63-0.59-1.71,0.13-2.24 C7.33,10.79,9.57,10,12,10c2.43,0,4.67,0.79,6.49,2.13c0.72,0.53,0.76,1.6,0.13,2.24c-0.53,0.54-1.37,0.57-1.98,0.12 C15.33,13.55,13.73,13,12,13c-1.73,0-3.33,0.55-4.64,1.49C6.75,14.93,5.91,14.9,5.38,14.37z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

