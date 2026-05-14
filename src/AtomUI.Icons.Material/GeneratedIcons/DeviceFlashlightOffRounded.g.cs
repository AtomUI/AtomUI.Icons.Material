// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceFlashlightOffRounded : MaterialIcon
{
    public DeviceFlashlightOffRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.71, 2, 19.16, 20.289999999999999);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0767160161507403, 0, 0, 1.0767160161507403, -0.9205921938088828, -0.9205921938088828);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,5V4c0-1.1-0.9-2-2-2H8C7.14,2,6.42,2.54,6.13,3.3L7.83,5H18z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(16, 11),new Avalonia.Point(18, 8),new Avalonia.Point(18, 7),new Avalonia.Point(9.83, 7),new Avalonia.Point(16, 13.17)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.1,3.51L2.1,3.51c-0.39,0.39-0.39,1.02,0,1.41l5.9,5.9L8,20c0,1.1,0.9,2,2,2h4c1.1,0,2-0.9,2-2v-1.17l3.07,3.07 c0.39,0.39,1.02,0.39,1.41,0l0,0c0.39-0.39,0.39-1.02,0-1.41L3.51,3.51C3.12,3.12,2.49,3.12,2.1,3.51z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

