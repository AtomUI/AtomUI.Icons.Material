// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionInstallDesktopTwoTone : MaterialIcon
{
    public ActionInstallDesktopTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 3, 20, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(14.83, 9),new Avalonia.Point(14.83, 9),new Avalonia.Point(16, 10.17)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(4, 17),new Avalonia.Point(20, 17),new Avalonia.Point(20, 13.83),new Avalonia.Point(17, 16.83),new Avalonia.Point(9.17, 9),new Avalonia.Point(13, 5.17),new Avalonia.Point(13, 5),new Avalonia.Point(4, 5)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,17H4V5h9V3H4C2.89,3,2,3.89,2,5v12c0,1.1,0.89,2,2,2h4v2h8v-2h4c1.1,0,2-0.9,2-2v-5.17l-2,2V17z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(18, 10.17),new Avalonia.Point(18, 3),new Avalonia.Point(16, 3),new Avalonia.Point(16, 10.17),new Avalonia.Point(13.41, 7.59),new Avalonia.Point(12, 9),new Avalonia.Point(17, 14),new Avalonia.Point(22, 9),new Avalonia.Point(20.59, 7.59)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

