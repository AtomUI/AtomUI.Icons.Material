// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class NavigationOfflineShareSharp : MaterialIcon
{
    public NavigationOfflineShareSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 1, 16, 22);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6, 5),new Avalonia.Point(4, 5),new Avalonia.Point(4, 23),new Avalonia.Point(16, 23),new Avalonia.Point(16, 21),new Avalonia.Point(6, 21)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,1H8v18h12V1z M18,15h-8V5h8V15z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(12.5, 10.25),new Avalonia.Point(14.5, 10.25),new Avalonia.Point(14.5, 12),new Avalonia.Point(17, 9.5),new Avalonia.Point(14.5, 7),new Avalonia.Point(14.5, 8.75),new Avalonia.Point(11, 8.75),new Avalonia.Point(11, 12),new Avalonia.Point(12.5, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

