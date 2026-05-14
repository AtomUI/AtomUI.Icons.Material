// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsEditLocationSharp : MaterialIcon
{
    public MapsEditLocationSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 0.10000000000000001, 17.900000000000002, 21.909999999999997);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.00418410041841, 0, 0, 1.00418410041841, -0.050209205020919967, -0.050209205020919967);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18.11 1.77L19.78.1l2.12 2.12-1.67 1.67-2.12-2.12zm-1 1l2.12 2.12L13.12 11H11V8.89l6.11-6.12zm-1.98-.13L9.5 8.27v4.24h4.24l5.62-5.62c.41.99.64 2.1.64 3.32 0 3.32-2.67 7.25-8 11.8-5.33-4.55-8-8.48-8-11.8 0-4.98 3.8-8.2 8-8.2 1.09 0 2.16.22 3.13.63z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

