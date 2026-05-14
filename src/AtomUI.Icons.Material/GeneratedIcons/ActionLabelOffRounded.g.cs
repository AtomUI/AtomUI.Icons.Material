// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionLabelOffRounded : MaterialIcon
{
    public ActionLabelOffRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.3299999999999996, 2.9199999999999999, 19.510000000000002, 17.759999999999998);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1162790697674418, 0, 0, 1.1162790697674418, -1.3953488372093013, -1.3953488372093013);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21.59 12.58c.25-.35.25-.81 0-1.16l-3.96-5.58C17.27 5.33 16.67 5 16 5H8.66l10.7 10.73 2.23-3.15zM2.72 4.72l.87.87C3.23 5.95 3 6.45 3 7v10c0 1.1.9 2 2 2h12l1.29 1.29c.39.39 1.02.39 1.41 0 .39-.39.39-1.02 0-1.41L4.14 3.31c-.38-.38-1.01-.39-1.4-.01-.41.38-.41 1.03-.02 1.42z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

