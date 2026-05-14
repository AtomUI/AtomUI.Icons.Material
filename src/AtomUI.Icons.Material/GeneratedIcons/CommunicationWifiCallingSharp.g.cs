// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class CommunicationWifiCallingSharp : MaterialIcon
{
    public CommunicationWifiCallingSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.4500000000000002, 3, 19.550000000000001, 18.550000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1374407582938388, 0, 0, 1.1374407582938388, -1.6492890995260652, -1.6492890995260652);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13.21,17.37c-2.83-1.44-5.15-3.75-6.59-6.59l2.53-2.53L8.54,3H3.03C2.45,13.18,10.82,21.55,21,20.97v-5.51l-5.27-0.61 L13.21,17.37z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,4.95C21.79,4.78,19.67,3,16.5,3c-3.18,0-5.29,1.78-5.5,1.95L16.5,12L22,4.95z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

