// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorFormatColorTextRounded : MaterialIcon
{
    public EditorFormatColorTextRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 3, 20, 21);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,20H4c-1.1,0-2,0.9-2,2s0.9,2,2,2h16c1.1,0,2-0.9,2-2S21.1,20,20,20z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M7.11,17L7.11,17c0.48,0,0.91-0.3,1.06-0.75l1.01-2.83h5.65l0.99,2.82C15.98,16.7,16.41,17,16.89,17 c0.79,0,1.33-0.79,1.05-1.52L13.69,4.17C13.43,3.47,12.75,3,12,3s-1.43,0.47-1.69,1.17L6.06,15.48C5.78,16.21,6.33,17,7.11,17z M11.94,5.6h0.12l2.03,5.79H9.91L11.94,5.6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

