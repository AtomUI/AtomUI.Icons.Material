// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialAssistWalkerSharp : MaterialIcon
{
    public SocialAssistWalkerSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.1499999999999999, 2.5, 18.350000000000001, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0983981693363845, 0, 0, 1.0983981693363845, -1.1807780320366135, -1.1807780320366135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(12.5, 4.5),
            Radius = 2
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19.77,17.72L19,10h-3c-1.5-0.02-2.86-0.54-3.76-1.44l-2-1.98C10.08,6.42,9.62,6,8.83,6C8.32,6,7.81,6.2,7.42,6.59 l-4.2,4.17l2.08,4.07l-3.15,4.05l1.57,1.24l3.68-4.73l-0.17-1.36L8,14.75V20h2v-6.12l-2.12-2.12l2.36-2.36 c0.94,0.94,1.72,1.82,3.59,2.32L13,20h1.5l0.41-3.5h3.18l0.14,1.22c-0.44,0.26-0.73,0.74-0.73,1.28c0,0.83,0.67,1.5,1.5,1.5 s1.5-0.67,1.5-1.5C20.5,18.46,20.21,17.98,19.77,17.72z M15.09,15l0.41-3.5h2l0.41,3.5H15.09z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

