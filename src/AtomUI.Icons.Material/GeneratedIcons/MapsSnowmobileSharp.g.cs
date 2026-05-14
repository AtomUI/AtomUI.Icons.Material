// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsSnowmobileSharp : MaterialIcon
{
    public MapsSnowmobileSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(-0.77000000000000002, 5, 24.77, 15);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96891400888171175, 0, 0, 0.96891400888171175, 0.37303189341945853, 0.37303189341945853);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,17c0,0.55-0.45,1-1,1h-0.17l-2.2-2.2C21.6,15.18,23,13,23,13l-9-8h-3v2h2.25l1.45,1.3L11,11l-9.5-1L0,13l4.54,1.36 l-3.49,1.88C-0.77,17.22-0.07,20,2,20h6c2.21,0,4-1.79,4-4h4l2,2h-3v2h6c1.66,0,3-1.34,3-3H22z M8,18H2l5.25-2.83L10,16 C10,17.1,9.11,18,8,18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

