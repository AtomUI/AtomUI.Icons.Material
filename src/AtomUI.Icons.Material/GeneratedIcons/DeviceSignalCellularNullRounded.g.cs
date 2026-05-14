// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceSignalCellularNullRounded : MaterialIcon
{
    public DeviceSignalCellularNullRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.0800000000000001, 3.0800000000000001, 18.920000000000002, 18.920000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2096774193548387, 0, 0, 1.2096774193548387, -2.5161290322580641, -2.5161290322580641);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20 6.83V19c0 .55-.45 1-1 1H6.83L20 6.83m.29-3.12L3.71 20.29c-.63.63-.19 1.71.7 1.71H20c1.1 0 2-.9 2-2V4.41c0-.89-1.08-1.33-1.71-.7z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

