// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionPhpSharp : MaterialIcon
{
    public ActionPhpSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 9, 18.5, 6);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1707317073170731, 0, 0, 1.1707317073170731, -2.0487804878048763, -2.0487804878048763);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13,9h1.5v6H13v-2.5h-2V15H9.5V9H11v2h2V9z M8,9v4H4.5v2H3V9H8z M6.5,10.5h-2v1h2V10.5z M21.5,9v4H18v2h-1.5V9H21.5z M20,10.5h-2v1h2V10.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

