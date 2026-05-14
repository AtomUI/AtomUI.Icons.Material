// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionOutputSharp : MaterialIcon
{
    public ActionOutputSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 19, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(17, 17),new Avalonia.Point(22, 12),new Avalonia.Point(17, 7),new Avalonia.Point(15.59, 8.41),new Avalonia.Point(18.17, 11),new Avalonia.Point(9, 11),new Avalonia.Point(9, 13),new Avalonia.Point(18.17, 13),new Avalonia.Point(15.59, 15.59)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(19, 19),new Avalonia.Point(5, 19),new Avalonia.Point(5, 5),new Avalonia.Point(19, 5),new Avalonia.Point(19, 7),new Avalonia.Point(21, 7),new Avalonia.Point(21, 3),new Avalonia.Point(3, 3),new Avalonia.Point(3, 21),new Avalonia.Point(21, 21),new Avalonia.Point(21, 17),new Avalonia.Point(19, 17)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
