// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class FileFolderOffSharp : MaterialIcon
{
    public FileFolderOffSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0.68999999999999995, 2.1000000000000001, 21.309999999999999, 21.209999999999997);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0296010296010294, 0, 0, 1.0296010296010294, -0.35521235521235184, -0.35521235521235184);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(12, 6),new Avalonia.Point(10, 4),new Avalonia.Point(6.83, 4),new Avalonia.Point(22, 19.17),new Avalonia.Point(22, 6)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(2.1, 2.1),new Avalonia.Point(0.69, 3.51),new Avalonia.Point(2, 4.83),new Avalonia.Point(2, 20),new Avalonia.Point(17.17, 20),new Avalonia.Point(20.49, 23.31),new Avalonia.Point(21.9, 21.9)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

