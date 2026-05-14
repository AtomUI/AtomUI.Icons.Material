// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageLooksRounded : MaterialIcon
{
    public ImageLooksRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 6, 22.009999999999998, 11);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0439321444106133, 0, 0, 1.0439321444106133, -0.52718573292736082, -0.52718573292736082);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12 10c-3.47 0-6.36 2.54-6.91 5.86-.1.6.39 1.14 1 1.14.49 0 .9-.36.98-.85C7.48 13.79 9.53 12 12 12s4.52 1.79 4.93 4.15c.08.49.49.85.98.85.61 0 1.09-.54.99-1.14C18.36 12.54 15.47 10 12 10zm0-4C6.3 6 1.61 10.34 1.05 15.9c-.05.59.41 1.1 1.01 1.1.51 0 .94-.38.99-.88C3.49 11.57 7.34 8 12 8s8.51 3.57 8.96 8.12c.05.5.48.88.99.88.59 0 1.06-.51 1-1.1C22.39 10.34 17.7 6 12 6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

