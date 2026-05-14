// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageViewCompactOutlined : MaterialIcon
{
    public ImageViewCompactOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 4, 20, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M2,4v16h20V4H2z M6.5,18H4v-2.5h2.5V18z M6.5,13.25H4v-2.5h2.5V13.25z M6.5,8.5H4V6h2.5V8.5z M11,18H8.5v-2.5H11V18z M11,13.25H8.5v-2.5H11V13.25z M11,8.5H8.5V6H11V8.5z M15.5,18H13v-2.5h2.5V18z M15.5,13.25H13v-2.5h2.5V13.25z M15.5,8.5H13V6 h2.5V8.5z M20,18h-2.5v-2.5H20V18z M20,13.25h-2.5v-2.5H20V13.25z M20,8.5h-2.5V6H20V8.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

