// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageFaceRetouchingNaturalSharp : MaterialIcon
{
    public ImageFaceRetouchingNaturalSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, -0.14000000000000001, 22.119999999999997, 22.140000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.98441345365053345, 0, 0, 0.98441345365053345, 0.18703855619359899, 0.18703855619359899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(9, 13),
            Radius = 1.25
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19.85,10.59C20.79,15.4,17.01,20,12,20c-4.41,0-8-3.59-8-8c0-0.39,3.87-1.12,5.74-5.69c3.42,4.19,8.07,3.73,9.09,3.59 l-1.48-3.25L12.63,4.5l3.5-1.59C9.51-0.14,2,4.77,2,12c0,5.52,4.48,10,10,10c7.21,0,12.12-7.45,9.1-14.13L19.85,10.59z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(15, 13),
            Radius = 1.25
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20.6,5.6L19.5,8l-1.1-2.4L16,4.5l2.4-1.1L19.5,1l1.1,2.4L23,4.5L20.6,5.6z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

