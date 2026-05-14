// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionDataThresholdingSharp : MaterialIcon
{
    public ActionDataThresholdingSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21,3H3v18h18V3z M10.67,8.17l2,2l3.67-3.67l1.41,1.41L12.67,13l-2-2l-3,3l-1.41-1.41L10.67,8.17z M5,16h1.72L5,17.72V16z M5.84,19l3-3h1.83l-3,3H5.84z M9.8,19l3-3h1.62l-3,3H9.8z M13.53,19l3-3h1.62l-3,3H13.53z M19,19h-1.73L19,17.27V19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

