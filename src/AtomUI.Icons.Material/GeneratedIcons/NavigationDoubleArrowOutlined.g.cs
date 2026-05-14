// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class NavigationDoubleArrowOutlined : MaterialIcon
{
    public NavigationDoubleArrowOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 5, 16.5, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2307692307692308, 0, 0, 1.2307692307692308, -2.7692307692307701, -2.7692307692307701);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(15.5, 5),new Avalonia.Point(11, 5),new Avalonia.Point(16, 12),new Avalonia.Point(11, 19),new Avalonia.Point(15.5, 19),new Avalonia.Point(20.5, 12)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(8.5, 5),new Avalonia.Point(4, 5),new Avalonia.Point(9, 12),new Avalonia.Point(4, 19),new Avalonia.Point(8.5, 19),new Avalonia.Point(13.5, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

