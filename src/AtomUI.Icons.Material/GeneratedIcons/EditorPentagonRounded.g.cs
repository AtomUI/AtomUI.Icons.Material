// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorPentagonRounded : MaterialIcon
{
    public EditorPentagonRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.1899999999999999, 2.3199999999999998, 19.619999999999997, 18.68);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1004126547455295, 0, 0, 1.1004126547455295, -1.2049518569463551, -1.2049518569463551);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M2.47,10.42l3.07,9.22C5.82,20.45,6.58,21,7.44,21h9.12c0.86,0,1.63-0.55,1.9-1.37l3.07-9.22 c0.28-0.84-0.03-1.76-0.75-2.27L13.15,2.8c-0.69-0.48-1.61-0.48-2.29,0L3.22,8.14C2.5,8.65,2.19,9.58,2.47,10.42z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

