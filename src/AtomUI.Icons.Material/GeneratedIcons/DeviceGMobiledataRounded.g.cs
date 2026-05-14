// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceGMobiledataRounded : MaterialIcon
{
    public DeviceGMobiledataRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(7, 7, 9, 10);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.411764705882353, 0, 0, 1.411764705882353, -4.9411764705882355, -4.9411764705882355);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,12L12,12c0,0.55,0.45,1,1,1h1v2H9V9h6c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H9C7.9,7,7,7.9,7,9v6c0,1.1,0.9,2,2,2h5 c1.1,0,2-0.9,2-2v-3c0-0.55-0.45-1-1-1h-2C12.45,11,12,11.45,12,12z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

