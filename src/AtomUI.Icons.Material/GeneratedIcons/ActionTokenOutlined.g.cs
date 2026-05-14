// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionTokenOutlined : MaterialIcon
{
    public ActionTokenOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 2, 18, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M21,7l-9-5L3,7v10l9,5l9-5L21,7z M12,4.29l5.91,3.28L14.9,9.24C14.17,8.48,13.14,8,12,8S9.83,8.48,9.1,9.24L6.09,7.57 L12,4.29z M11,19.16l-6-3.33V9.26l3.13,1.74C8.04,11.31,8,11.65,8,12c0,1.86,1.27,3.43,3,3.87V19.16z M10,12c0-1.1,0.9-2,2-2 s2,0.9,2,2s-0.9,2-2,2S10,13.1,10,12z M13,19.16v-3.28c1.73-0.44,3-2.01,3-3.87c0-0.35-0.04-0.69-0.13-1.01L19,9.26l0,6.57L13,19.16 z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

