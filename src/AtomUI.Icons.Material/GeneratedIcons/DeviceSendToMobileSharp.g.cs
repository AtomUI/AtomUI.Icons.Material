// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceSendToMobileSharp : MaterialIcon
{
    public DeviceSendToMobileSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 1, 17, 22);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(17, 18),new Avalonia.Point(7, 18),new Avalonia.Point(7, 6),new Avalonia.Point(17, 6),new Avalonia.Point(17, 7),new Avalonia.Point(19, 7),new Avalonia.Point(19, 1),new Avalonia.Point(5, 1),new Avalonia.Point(5, 23),new Avalonia.Point(19, 23),new Avalonia.Point(19, 17),new Avalonia.Point(17, 17)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(22, 12),new Avalonia.Point(18, 8),new Avalonia.Point(18, 11),new Avalonia.Point(13, 11),new Avalonia.Point(13, 13),new Avalonia.Point(18, 13),new Avalonia.Point(18, 16)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

