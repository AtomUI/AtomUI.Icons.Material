// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceTimer10SelectTwoTone : MaterialIcon
{
    public DeviceTimer10SelectTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 5, 22, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M13,8v8h-3V8H13 M13,5h-3C8.34,5,7,6.34,7,8v8c0,1.66,1.34,3,3,3h3c1.66,0,3-1.34,3-3V8C16,6.34,14.66,5,13,5z M1,8h2v11h3 V5H1V8z M18.5,11c-0.83,0-1.5,0.68-1.5,1.5v2c0,0.82,0.67,1.5,1.5,1.5H21v1h-4v2h4.5c0.83,0,1.5-0.67,1.5-1.5v-2 c0-0.83-0.67-1.5-1.5-1.5H19v-1h4v-2H18.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

