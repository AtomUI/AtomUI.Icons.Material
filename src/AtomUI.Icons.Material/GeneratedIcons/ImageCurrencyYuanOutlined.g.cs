// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageCurrencyYuanOutlined : MaterialIcon
{
    public ImageCurrencyYuanOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 3, 14, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(13.28, 12),new Avalonia.Point(18, 12),new Avalonia.Point(18, 14),new Avalonia.Point(13, 14),new Avalonia.Point(13, 21),new Avalonia.Point(11, 21),new Avalonia.Point(11, 14),new Avalonia.Point(6, 14),new Avalonia.Point(6, 12),new Avalonia.Point(10.72, 12),new Avalonia.Point(5, 3),new Avalonia.Point(7.37, 3),new Avalonia.Point(12, 10.29),new Avalonia.Point(16.63, 3),new Avalonia.Point(19, 3)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

