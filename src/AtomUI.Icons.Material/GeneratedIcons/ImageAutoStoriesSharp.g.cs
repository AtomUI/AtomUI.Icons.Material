// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageAutoStoriesSharp : MaterialIcon
{
    public ImageAutoStoriesSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 0.5, 22, 19.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0212765957446808, 0, 0, 1.0212765957446808, -0.25531914893617014, -0.25531914893617014);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21,4.6v2.12v7.24v2.66C19.86,16.21,18.69,16,17.5,16c-1.9,0-3.78,0.54-5.5,1.58v-3.62V7.79V5.48C10.38,4.55,8.51,4,6.5,4 S2.62,4.55,1,5.48V20c1.52-1.18,3.43-2,5.5-2s3.98,0.82,5.5,2c1.52-1.18,3.43-2,5.5-2s3.98,0.82,5.5,2V5.48 C22.37,5.12,21.7,4.84,21,4.6z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(19, 0.5),new Avalonia.Point(14, 5.5),new Avalonia.Point(14, 15),new Avalonia.Point(19, 10.5)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

