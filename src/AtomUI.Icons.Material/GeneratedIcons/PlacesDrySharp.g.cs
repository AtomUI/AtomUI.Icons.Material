// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesDrySharp : MaterialIcon
{
    public PlacesDrySharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 2, 21, 21);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M1,12.68V23h18v-2.5h-7v-1h9V17h-9v-1h10v-2.5H12v-1h8V10H8.86l1.88-3.3L9.12,5L1,12.68z M15.65,4.86l-0.07-0.07 c-0.57-0.62-0.82-1.41-0.67-2.2L15,2h-1.89l-0.06,0.43c-0.2,1.36,0.27,2.71,1.3,3.72l0.07,0.06c0.57,0.62,0.82,1.41,0.67,2.2 L14.98,9h1.91l0.06-0.43C17.16,7.21,16.68,5.86,15.65,4.86z M19.65,4.86l-0.07-0.07c-0.57-0.62-0.82-1.41-0.67-2.2L19,2h-1.89 l-0.06,0.43c-0.2,1.36,0.27,2.71,1.3,3.72l0.07,0.06c0.57,0.62,0.82,1.41,0.67,2.2L18.98,9h1.91l0.06-0.43 C21.16,7.21,20.68,5.86,19.65,4.86z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

