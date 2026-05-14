// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialSelfImprovementRounded : MaterialIcon
{
    public SocialSelfImprovementRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 4, 18, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(12, 6),
            Radius = 2
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21,14.94L21,14.94c0-0.5-0.36-0.93-0.85-0.98c-1.88-0.21-3.49-1.13-4.75-2.63l-1.34-1.6C13.68,9.26,13.12,9,12.53,9 h-1.05c-0.59,0-1.15,0.26-1.53,0.72l-1.34,1.6c-1.25,1.5-2.87,2.42-4.75,2.63C3.36,14.01,3,14.44,3,14.94v0 c0,0.6,0.53,1.07,1.13,1c2.3-0.27,4.32-1.39,5.87-3.19V15l-3.76,1.5c-0.65,0.26-1.16,0.83-1.23,1.53C4.91,19.1,5.74,20,6.79,20H9 v-0.5c0-1.38,1.12-2.5,2.5-2.5h3c0.28,0,0.5,0.22,0.5,0.5S14.78,18,14.5,18h-3c-0.83,0-1.5,0.67-1.5,1.5V20l7.1,0 c0.85,0,1.65-0.54,1.85-1.37c0.21-0.89-0.27-1.76-1.08-2.08L14,15v-2.25c1.56,1.8,3.57,2.91,5.87,3.19C20.47,16,21,15.54,21,14.94 z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

