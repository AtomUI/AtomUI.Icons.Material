// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceRsvpSharp : MaterialIcon
{
    public DeviceRsvpSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 9, 22, 6);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M16,9h1.5l-1.75,6h-1.5L12.5,9H14l1,3.43L16,9z M5.14,13L6,15H4.5l-0.85-2H2.5v2H1V9h5v4L5.14,13z M4.5,10.5h-2v1h2V10.5z M23,13h-3.5v2H18V9h5V13z M21.5,10.5h-2v1h2V10.5z M11.5,9v1.5h-3v0.75h3V15H7v-1.5h3v-0.75H7V9H11.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

