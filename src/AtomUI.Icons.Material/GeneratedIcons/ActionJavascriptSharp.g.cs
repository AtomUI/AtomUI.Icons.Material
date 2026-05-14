// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionJavascriptSharp : MaterialIcon
{
    public ActionJavascriptSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 9, 11, 6);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.3333333333333333, 0, 0, 1.3333333333333333, -4, -4);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,15v-2h1.5v0.5h2v-1H12V9h5v2h-1.5v-0.5h-2v1H17V15H12z M9,9v4.5H7.5v-1H6V15h4.5V9H9z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

