// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionLabelImportantOutlineRounded : MaterialIcon
{
    public ActionLabelImportantOutlineRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.5600000000000001, 5, 17.280000000000001, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1976047904191618, 0, 0, 1.1976047904191618, -2.3712574850299415, -2.3712574850299415);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15 19H4.83c-.79 0-1.27-.88-.84-1.54L7.5 12 3.99 6.54C3.56 5.88 4.04 5 4.83 5H15c.65 0 1.26.31 1.63.84l3.96 5.58c.25.35.25.81 0 1.16l-3.96 5.58c-.37.52-.98.84-1.63.84zm-8.5-2H15l3.5-5L15 7H6.5l3.5 5-3.5 5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

