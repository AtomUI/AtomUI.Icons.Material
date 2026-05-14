// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class SocialCo2Sharp : MaterialIcon
{
    public SocialCo2Sharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 9, 18.5, 9);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1707317073170731, 0, 0, 1.1707317073170731, -2.0487804878048763, -2.0487804878048763);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15,9h-5v6h5V9z M13.5,13.5h-2v-3h2V13.5z M8,13v2H3V9h5v2H6.5v-0.5h-2v3h2V13H8z M18.5,15.5v1h3V18H17v-3.5h3v-1h-3V12h4.5 v3.5H18.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

