// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class Action123Sharp : MaterialIcon
{
    public Action123Sharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 9, 15.5, 6);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M7,15H5.5v-4.5H4V9h3V15z M13.5,13.5h-3v-1h3V9H9v1.5h3v1H9V15h4.5V13.5z M19.5,15V9H15v1.5h3v1h-2v1h2v1h-3V15H19.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

