// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceNetworkWifi2BarRounded : MaterialIcon
{
    public DeviceNetworkWifi2BarRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.32000000000000001, 4, 23.359999999999999, 16.68);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0135135135135136, 0, 0, 1.0135135135135136, -0.16216216216216317, -0.16216216216216317);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,4C7.7,4,3.78,5.6,0.79,8.24C0.35,8.63,0.32,9.3,0.73,9.71l10.56,10.58c0.39,0.39,1.02,0.39,1.42,0L23.27,9.71 c0.41-0.41,0.38-1.08-0.06-1.47C20.22,5.6,16.3,4,12,4z M16.78,13.38C15.4,12.5,13.76,12,12,12c-1.76,0-3.4,0.5-4.78,1.38l-4.3-4.3 C5.51,7.08,8.67,6,12,6s6.49,1.08,9.08,3.07L16.78,13.38z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

