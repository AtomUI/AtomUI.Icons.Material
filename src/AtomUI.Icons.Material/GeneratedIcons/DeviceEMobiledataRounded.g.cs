// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceEMobiledataRounded : MaterialIcon
{
    public DeviceEMobiledataRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(8, 7, 8, 10);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.411764705882353, 0, 0, 1.411764705882353, -4.9411764705882355, -4.9411764705882355);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M16,8L16,8c0-0.55-0.45-1-1-1H9C8.45,7,8,7.45,8,8v8c0,0.55,0.45,1,1,1h6c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h-5v-2h5 c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1h-5V9h5C15.55,9,16,8.55,16,8z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

