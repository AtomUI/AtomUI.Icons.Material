// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsEmergencyFilled : MaterialIcon
{
    public MapsEmergencyFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.21, 3, 17.579999999999998, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(20.79, 9.23),new Avalonia.Point(18.79, 5.77),new Avalonia.Point(14, 8.54),new Avalonia.Point(14, 3),new Avalonia.Point(10, 3),new Avalonia.Point(10, 8.54),new Avalonia.Point(5.21, 5.77),new Avalonia.Point(3.21, 9.23),new Avalonia.Point(8, 12),new Avalonia.Point(3.21, 14.77),new Avalonia.Point(5.21, 18.23),new Avalonia.Point(10, 15.46),new Avalonia.Point(10, 21),new Avalonia.Point(14, 21),new Avalonia.Point(14, 15.46),new Avalonia.Point(18.79, 18.23),new Avalonia.Point(20.79, 14.77),new Avalonia.Point(16, 12)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

