// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsWarehouseRounded : MaterialIcon
{
    public MapsWarehouseRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 3.0999999999999992, 20, 17.900000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,19V8.35c0-0.82-0.5-1.55-1.26-1.86l-8-3.2c-0.48-0.19-1.01-0.19-1.49,0l-8,3.2C2.5,6.8,2,7.54,2,8.35V19 c0,1.1,0.9,2,2,2h3v-9h10v9h3C21.1,21,22,20.1,22,19z M11,19H9v2h2V19z M13,16h-2v2h2V16z M15,19h-2v2h2V19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

