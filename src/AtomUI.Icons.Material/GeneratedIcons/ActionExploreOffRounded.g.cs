// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionExploreOffRounded : MaterialIcon
{
    public ActionExploreOffRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.6600000000000001, 2, 20.34, 20.34);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0743061772605194, 0, 0, 1.0743061772605194, -0.89167412712623317, -0.89167412712623317);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18 6l-2.91 6.26 5.25 5.25C21.39 15.93 22 14.04 22 12c0-5.52-4.48-10-10-10-2.04 0-3.93.61-5.51 1.66l5.25 5.25L18 6zM2.81 5.64l.85.85c-1.37 2.07-2 4.68-1.48 7.45.75 3.95 3.92 7.13 7.88 7.88 2.77.52 5.38-.1 7.45-1.48l.85.85c.39.39 1.02.39 1.41 0 .39-.39.39-1.02 0-1.41L4.22 4.22c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.03 0 1.42zm6.1 6.1l3.35 3.35L6 18l2.91-6.26z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

