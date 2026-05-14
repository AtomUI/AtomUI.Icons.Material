// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceFlashlightOffTwoTone : MaterialIcon
{
    public DeviceFlashlightOffTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.3899999999999999, 2, 19.800000000000001, 20.609999999999999);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0614772224679345, 0, 0, 1.0614772224679345, -0.73772666961521338, -0.73772666961521338);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(16, 7),new Avalonia.Point(9.83, 7),new Avalonia.Point(14, 11.17),new Avalonia.Point(14, 10.4),new Avalonia.Point(16, 7.39)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(10, 12.83),new Avalonia.Point(10, 20),new Avalonia.Point(14, 20),new Avalonia.Point(14, 16.83)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(16, 5),new Avalonia.Point(16, 4),new Avalonia.Point(6.83, 4),new Avalonia.Point(7.83, 5)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M2.81,2.81L1.39,4.22L8,10.83V22h8v-3.17l3.78,3.78l1.41-1.41L2.81,2.81z M14,20h-4v-7.17l4,4V20z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(16, 4),new Avalonia.Point(16, 5),new Avalonia.Point(7.83, 5),new Avalonia.Point(9.83, 7),new Avalonia.Point(16, 7),new Avalonia.Point(16, 7.39),new Avalonia.Point(14, 10.4),new Avalonia.Point(14, 11.17),new Avalonia.Point(16, 13.17),new Avalonia.Point(16, 11),new Avalonia.Point(18, 8),new Avalonia.Point(18, 2),new Avalonia.Point(6, 2),new Avalonia.Point(6, 3.17),new Avalonia.Point(6.83, 4)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

