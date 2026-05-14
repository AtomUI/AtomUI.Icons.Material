// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionInstallDesktopSharp : MaterialIcon
{
    public ActionInstallDesktopSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 3, 20, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(20, 17),new Avalonia.Point(4, 17),new Avalonia.Point(4, 5),new Avalonia.Point(12, 5),new Avalonia.Point(12, 3),new Avalonia.Point(2, 3),new Avalonia.Point(2, 19),new Avalonia.Point(8, 19),new Avalonia.Point(8, 21),new Avalonia.Point(16, 21),new Avalonia.Point(16, 19),new Avalonia.Point(22, 19),new Avalonia.Point(22, 14),new Avalonia.Point(20, 14)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(17, 14),new Avalonia.Point(22, 9),new Avalonia.Point(20.59, 7.59),new Avalonia.Point(18, 10.17),new Avalonia.Point(18, 3),new Avalonia.Point(16, 3),new Avalonia.Point(16, 10.17),new Avalonia.Point(13.41, 7.59),new Avalonia.Point(12, 9)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

