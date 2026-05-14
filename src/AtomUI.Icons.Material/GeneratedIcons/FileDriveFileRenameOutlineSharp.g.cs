// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class FileDriveFileRenameOutlineSharp : MaterialIcon
{
    public FileDriveFileRenameOutlineSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3.5841709999999996, 18, 16.415829000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(15, 16),new Avalonia.Point(11, 20),new Avalonia.Point(21, 20),new Avalonia.Point(21, 16)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(12.06, 7.19),new Avalonia.Point(3, 16.25),new Avalonia.Point(3, 20),new Avalonia.Point(6.75, 20),new Avalonia.Point(15.81, 10.94)]
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(14.48, 4.08, 3.59, 5.3),
            RadiusX = 0,
            RadiusY = 0,
            Transform = new Matrix(0.70709999999999995, -0.70709999999999995, 0.70709999999999995, 0.70709999999999995, 0.0082572889999999993, 13.4765)
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

