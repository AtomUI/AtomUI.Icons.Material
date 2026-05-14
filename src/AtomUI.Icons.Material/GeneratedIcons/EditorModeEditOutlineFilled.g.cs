// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorModeEditOutlineFilled : MaterialIcon
{
    public EditorModeEditOutlineFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 2.8999999999999999, 18.100000000000001, 18.100000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1374407582938391, 0, 0, 1.1374407582938391, -1.6492890995260687, -1.6492890995260687);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(3, 17.25),new Avalonia.Point(3, 21),new Avalonia.Point(6.75, 21),new Avalonia.Point(17.81, 9.94),new Avalonia.Point(14.06, 6.19)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20.71,5.63l-2.34-2.34c-0.39-0.39-1.02-0.39-1.41,0l-1.83,1.83l3.75,3.75l1.83-1.83C21.1,6.65,21.1,6.02,20.71,5.63z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

