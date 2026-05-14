// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class HardwareBrowserNotSupportedSharp : MaterialIcon
{
    public HardwareBrowserNotSupportedSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.95, 3.3199999999999998, 19.050000000000001, 18.739999999999998);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0889292196007259, 0, 0, 1.0889292196007259, -1.0671506352087103, -1.0671506352087103);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(19, 6),new Avalonia.Point(19, 16.5),new Avalonia.Point(21, 18.5),new Avalonia.Point(21, 4),new Avalonia.Point(6.5, 4),new Avalonia.Point(8.5, 6)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M3.22,3.32L1.95,4.59L3,5.64L3,20h14.36l2.06,2.06l1.27-1.27L3.22,3.32z M15,18H5V7.64L15.36,18H15z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

