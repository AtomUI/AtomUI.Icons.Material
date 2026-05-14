// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorAlignHorizontalCenterFilled : MaterialIcon
{
    public EditorAlignHorizontalCenterFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 2, 18, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(11, 2),new Avalonia.Point(13, 2),new Avalonia.Point(13, 7),new Avalonia.Point(21, 7),new Avalonia.Point(21, 10),new Avalonia.Point(13, 10),new Avalonia.Point(13, 14),new Avalonia.Point(18, 14),new Avalonia.Point(18, 17),new Avalonia.Point(13, 17),new Avalonia.Point(13, 22),new Avalonia.Point(11, 22),new Avalonia.Point(11, 17),new Avalonia.Point(6, 17),new Avalonia.Point(6, 14),new Avalonia.Point(11, 14),new Avalonia.Point(11, 10),new Avalonia.Point(3, 10),new Avalonia.Point(3, 7),new Avalonia.Point(11, 7)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

