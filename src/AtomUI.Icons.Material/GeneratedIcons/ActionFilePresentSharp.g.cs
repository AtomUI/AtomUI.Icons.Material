// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionFilePresentSharp : MaterialIcon
{
    public ActionFilePresentSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 2, 16, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M14,2H4v20h16V8L14,2z M16,15c0,2.21-1.79,4-4,4s-4-1.79-4-4V9.5C8,8.12,9.12,7,10.5,7S13,8.12,13,9.5V15h-2V9.5 C11,9.22,10.78,9,10.5,9S10,9.22,10,9.5V15c0,1.1,0.9,2,2,2s2-0.9,2-2v-4h2V15z M14,8V4l4,4H14z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

