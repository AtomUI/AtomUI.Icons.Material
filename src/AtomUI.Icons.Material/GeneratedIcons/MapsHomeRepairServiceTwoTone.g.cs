// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsHomeRepairServiceTwoTone : MaterialIcon
{
    public MapsHomeRepairServiceTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 4, 20, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,8h-3V6c0-1.1-0.9-2-2-2H9C7.9,4,7,4.9,7,6v2H4c-1.1,0-2,0.9-2,2v10h20V10C22,8.9,21.1,8,20,8z M9,6h6v2H9V6z M20,18 H4v-3h2v1h2v-1h8v1h2v-1h2V18z M20,13h-2v-1h-2v1H8v-1H6v1H4v-3h3h10h3V13z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(18, 16),new Avalonia.Point(16, 16),new Avalonia.Point(16, 15),new Avalonia.Point(8, 15),new Avalonia.Point(8, 16),new Avalonia.Point(6, 16),new Avalonia.Point(6, 15),new Avalonia.Point(4, 15),new Avalonia.Point(4, 18),new Avalonia.Point(20, 18),new Avalonia.Point(20, 15),new Avalonia.Point(18, 15)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(4, 10),new Avalonia.Point(4, 13),new Avalonia.Point(6, 13),new Avalonia.Point(6, 12),new Avalonia.Point(8, 12),new Avalonia.Point(8, 13),new Avalonia.Point(16, 13),new Avalonia.Point(16, 12),new Avalonia.Point(18, 12),new Avalonia.Point(18, 13),new Avalonia.Point(20, 13),new Avalonia.Point(20, 10),new Avalonia.Point(17, 10),new Avalonia.Point(7, 10)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

