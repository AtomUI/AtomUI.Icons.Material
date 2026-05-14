// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareHeadsetMicSharp : MaterialIcon
{
    public HardwareHeadsetMicSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 0.67999999999999972, 18, 22.32);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0291595197255574, 0, 0, 1.0291595197255574, -0.34991423670668809, -0.34991423670668809);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M11.4 1.02C6.62 1.33 3 5.51 3 10.31V20h6v-8H5v-1.71C5 6.45 7.96 3.11 11.79 3 15.76 2.89 19 6.06 19 10v2h-4v8h4v1h-7v2h9V10c0-5.17-4.36-9.32-9.6-8.98z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

