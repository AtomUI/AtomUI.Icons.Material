// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceCableRounded : MaterialIcon
{
    public DeviceCableRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 2.8599999999999999, 18, 18.280000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1352885525070955, 0, 0, 1.1352885525070955, -1.6234626300851467, -1.6234626300851467);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,5V4c0-0.55-0.45-1-1-1h-2c-0.55,0-1,0.45-1,1v1h0c-0.55,0-1,0.45-1,1v3c0,0.55,0.45,1,1,1h1l0,6.91 c0,1.04-0.76,1.98-1.79,2.08C14.01,19.11,13,18.17,13,17l0-9.86c0-2.13-1.61-3.99-3.74-4.13C6.93,2.86,5,4.7,5,7v7H4 c-0.55,0-1,0.45-1,1v3c0,0.55,0.45,1,1,1h0v1c0,0.55,0.45,1,1,1h2c0.55,0,1-0.45,1-1v-1h0c0.55,0,1-0.45,1-1v-3c0-0.55-0.45-1-1-1 H7l0-6.91c0-1.04,0.76-1.98,1.79-2.08C9.99,4.89,11,5.83,11,7l0,9.86c0,2.13,1.61,3.99,3.74,4.13C17.07,21.14,19,19.3,19,17v-7h1 c0.55,0,1-0.45,1-1V6C21,5.45,20.55,5,20,5L20,5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

