// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceSignalWifi4BarLockRounded : MaterialIcon
{
    public DeviceSignalWifi4BarLockRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.32000000000000001, 4, 23.359999999999999, 17);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0135135135135136, 0, 0, 1.0135135135135136, -0.16216216216216317, -0.16216216216216317);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M23.21,8.24C20.22,5.6,16.3,4,12,4S3.78,5.6,0.79,8.24C0.35,8.63,0.32,9.3,0.73,9.71l5.62,5.63l4.94,4.95 c0.39,0.39,1.02,0.39,1.42,0l2.34-2.34V15c0-0.45,0.09-0.88,0.23-1.29c0.54-1.57,2.01-2.71,3.77-2.71h2.94l1.29-1.29 C23.68,9.3,23.65,8.63,23.21,8.24z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,16v-1c0-1.1-0.9-2-2-2s-2,0.9-2,2v1c-0.55,0-1,0.45-1,1v3c0,0.55,0.45,1,1,1h4c0.55,0,1-0.45,1-1v-3 C23,16.45,22.55,16,22,16z M21,16h-2v-1c0-0.55,0.45-1,1-1s1,0.45,1,1V16z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

