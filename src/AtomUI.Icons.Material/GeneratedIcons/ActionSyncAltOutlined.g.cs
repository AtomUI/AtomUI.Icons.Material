// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionSyncAltOutlined : MaterialIcon
{
    public ActionSyncAltOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 4, 20, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(7.41, 13.41),new Avalonia.Point(6, 12),new Avalonia.Point(2, 16),new Avalonia.Point(6, 20),new Avalonia.Point(7.41, 18.59),new Avalonia.Point(5.83, 17),new Avalonia.Point(21, 17),new Avalonia.Point(21, 15),new Avalonia.Point(5.83, 15)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(16.59, 10.59),new Avalonia.Point(18, 12),new Avalonia.Point(22, 8),new Avalonia.Point(18, 4),new Avalonia.Point(16.59, 5.41),new Avalonia.Point(18.17, 7),new Avalonia.Point(3, 7),new Avalonia.Point(3, 9),new Avalonia.Point(18.17, 9)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

