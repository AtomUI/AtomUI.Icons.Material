// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ContentWebStoriesFilled : MaterialIcon
{
    public ContentWebStoriesFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 2, 20.5, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1162790697674418, 0, 0, 1.1162790697674418, -1.3953488372093013, -1.3953488372093013);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M17,4c1.1,0,2,0.9,2,2v12c0,1.1-0.9,2-2,2V4z M2,20c0,1.1,0.9,2,2,2h9c1.1,0,2-0.9,2-2V4c0-1.1-0.9-2-2-2H4 C2.9,2,2,2.9,2,4V20z M21,18c0.83,0,1.5-0.67,1.5-1.5v-9C22.5,6.67,21.83,6,21,6V18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

