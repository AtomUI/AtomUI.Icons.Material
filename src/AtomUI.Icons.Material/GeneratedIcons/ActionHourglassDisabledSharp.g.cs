// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionHourglassDisabledSharp : MaterialIcon
{
    public ActionHourglassDisabledSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.68999999999999995, 2, 21.210000000000001, 21.32);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0300429184549356, 0, 0, 1.0300429184549356, -0.36051502145922676, -0.36051502145922676);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(8, 4),new Avalonia.Point(16, 4),new Avalonia.Point(16, 7.5),new Avalonia.Point(13.16, 10.34),new Avalonia.Point(14.41, 11.59),new Avalonia.Point(18, 8.01),new Avalonia.Point(17.99, 8),new Avalonia.Point(18, 8),new Avalonia.Point(18, 2),new Avalonia.Point(6, 2),new Avalonia.Point(6, 3.17),new Avalonia.Point(8, 5.17)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.1,2.1L0.69,3.51l8.9,8.9L6,16l0.01,0.01H6V22h12v-1.17l2.49,2.49l1.41-1.41L2.1,2.1z M16,20H8v-3.5l2.84-2.84L16,18.83 V20z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

