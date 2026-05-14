// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class FileFileDownloadDoneSharp : MaterialIcon
{
    public FileFileDownloadDoneSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.8700000000000001, 4, 16.259999999999998, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1922503725782414, 0, 0, 1.1922503725782414, -2.3070044709388959, -2.3070044709388959);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(20.13, 5.41),new Avalonia.Point(18.72, 4),new Avalonia.Point(9.53, 13.19),new Avalonia.Point(5.28, 8.95),new Avalonia.Point(3.87, 10.36),new Avalonia.Point(9.53, 16.02)]
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(5, 18, 14, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

