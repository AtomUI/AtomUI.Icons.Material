// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class FileFolderOffTwoTone : MaterialIcon
{
    public FileFolderOffTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.68999999999999995, 2.1000000000000001, 21.309999999999999, 21.209999999999997);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0296010296010294, 0, 0, 1.0296010296010294, -0.35521235521235184, -0.35521235521235184);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(15.17, 18),new Avalonia.Point(4, 6.83),new Avalonia.Point(4, 18)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(11.17, 8),new Avalonia.Point(20, 17.17),new Avalonia.Point(20, 8)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M0.69,3.51l1.56,1.56C2.1,5.35,2.01,5.66,2.01,6L2,18c0,1.1,0.9,2,2,2h13.17l3.31,3.31l1.41-1.41L2.1,2.1L0.69,3.51z M15.17,18H4V6.83L15.17,18z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,6h-8l-2-2H7.17l4,4H20v9.17l1.76,1.76C21.91,18.65,22,18.34,22,18V8C22,6.9,21.1,6,20,6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

