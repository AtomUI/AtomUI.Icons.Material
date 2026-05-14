// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageImageNotSupportedRounded : MaterialIcon
{
    public ImageImageNotSupportedRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 2.4199999999999999, 20.579999999999998, 20.579999999999998);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21.19,21.19l-0.78-0.78L18,18l-4.59-4.59L3.59,3.59v0L2.81,2.81c-0.39-0.39-1.02-0.39-1.41,0C1,3.2,1,3.83,1.39,4.22 L3,5.83V19c0,1.1,0.9,2,2,2h13.17l1.61,1.61c0.39,0.39,1.02,0.39,1.41,0C21.58,22.22,21.58,21.58,21.19,21.19z M6.02,18 c-0.42,0-0.65-0.48-0.39-0.81l2.49-3.2c0.2-0.25,0.58-0.26,0.78-0.01l2.1,2.53L12.17,15l3,3H6.02z M21,18.17L5.83,3H19 c1.1,0,2,0.9,2,2V18.17z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

