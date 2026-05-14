// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceNearbyErrorSharp : MaterialIcon
{
    public DeviceNearbyErrorSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.1799999999999999, 1.1799999999999997, 20.82, 21.66);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0526315789473684, 0, 0, 1.0526315789473684, -0.63157894736842124, -0.63157894736842124);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,7.58L16.42,12L12,16.42L7.58,12L12,7.58z M12,19.2L4.8,12L12,4.8l6,6V7.17l-5.99-5.99L1.18,12.01l10.83,10.83 L18,16.83V13.2L12,19.2z M20,20h2v2h-2V20z M22,10h-2v8h2V10"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

