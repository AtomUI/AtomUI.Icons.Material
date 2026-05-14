// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class FileFolderOffFilled : MaterialIcon
{
    public FileFolderOffFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.68999999999999995, 2.1000000000000001, 21.309999999999999, 21.209999999999997);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0296010296010294, 0, 0, 1.0296010296010294, -0.35521235521235184, -0.35521235521235184);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,6h-8l-2-2H6.83l14.93,14.93C21.91,18.65,22,18.34,22,18V8C22,6.9,21.1,6,20,6z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.1,2.1L0.69,3.51l1.56,1.56C2.1,5.35,2.01,5.66,2.01,6L2,18c0,1.1,0.9,2,2,2h13.17l3.31,3.31l1.41-1.41L2.1,2.1z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

