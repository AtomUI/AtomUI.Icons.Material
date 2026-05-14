// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsLayersClearRounded : MaterialIcon
{
    public MapsLayersClearRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.3199999999999998, 1.1699999999999999, 19.509999999999998, 19.509999999999998);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0512483574244416, 0, 0, 1.0512483574244416, -0.6149802890932996, -0.6149802890932996);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19.99 9.79c.51-.4.51-1.18 0-1.58l-6.76-5.26c-.72-.56-1.73-.56-2.46 0L9.41 4.02l7.88 7.88 2.7-2.11zm0 3.49l-.01-.01c-.36-.28-.86-.28-1.22 0l-.05.04 1.4 1.4c.37-.41.34-1.07-.12-1.43zm1.45 5.6L4.12 1.56c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.02 0 1.41l3.52 3.52-2.22 1.72c-.51.4-.51 1.18 0 1.58l6.76 5.26c.72.56 1.73.56 2.46 0l.87-.68 1.42 1.42-2.92 2.27c-.36.28-.87.28-1.23 0l-6.15-4.78c-.36-.28-.86-.28-1.22 0-.51.4-.51 1.17 0 1.57l6.76 5.26c.72.56 1.73.56 2.46 0l3.72-2.89 3.07 3.07c.39.39 1.02.39 1.41 0 .41-.39.41-1.02.02-1.41z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

