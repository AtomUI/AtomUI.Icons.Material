// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class CommunicationPhoneEnabledSharp : MaterialIcon
{
    public CommunicationPhoneEnabledSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18.550000000000001, 18.550000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1735941320293399, 0, 0, 1.1735941320293399, -2.0831295843520792, -2.0831295843520792);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M3,15.46l5.27-0.61l2.52,2.52c2.83-1.44,5.15-3.75,6.59-6.59l-2.53-2.53L15.46,3h5.51 C21.55,13.18,13.18,21.55,3,20.97V15.46z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

