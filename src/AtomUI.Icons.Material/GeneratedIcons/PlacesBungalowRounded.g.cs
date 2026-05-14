// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesBungalowRounded : MaterialIcon
{
    public PlacesBungalowRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4.4400000000000004, 3.7300000000000004, 15.119999999999997, 17.27);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2282497441146367, 0, 0, 1.2282497441146367, -2.7389969293756415, -2.7389969293756415);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,16c0.55,0,1,0.45,1,1v4h3c0.55,0,1-0.45,1-1v-5.21l0.57,0.92c0.29,0.47,0.91,0.61,1.38,0.32 c0.47-0.29,0.61-0.91,0.32-1.38L12.85,4.36c-0.39-0.63-1.31-0.63-1.7,0L4.73,14.65c-0.29,0.47-0.15,1.09,0.32,1.38 c0.47,0.29,1.08,0.15,1.38-0.32L7,14.8V20c0,0.55,0.45,1,1,1h3v-4C11,16.45,11.45,16,12,16z M13,13c0,0.55-0.45,1-1,1s-1-0.45-1-1 s0.45-1,1-1S13,12.45,13,13z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

