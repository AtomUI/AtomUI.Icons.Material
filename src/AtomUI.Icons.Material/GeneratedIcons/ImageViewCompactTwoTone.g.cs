// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageViewCompactTwoTone : MaterialIcon
{
    public ImageViewCompactTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 4, 20, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M4,13.25h2.5v-2.5H4V13.25z M4,18h2.5v-2.5H4V18z M8.5,8.5H11V6H8.5V8.5z M17.5,18H20v-2.5h-2.5V18z M17.5,13.25H20v-2.5h-2.5V13.25z M17.5,6v2.5H20V6H17.5z M13,8.5h2.5V6H13V8.5z M8.5,13.25H11v-2.5H8.5V13.25z M8.5,18H11v-2.5 H8.5V18z M4,8.5h2.5V6H4V8.5z M13,13.25h2.5v-2.5H13V13.25z M13,18h2.5v-2.5H13V18z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M2,4v16h20V4H2z M6.5,18H4v-2.5h2.5V18z M6.5,13.25H4v-2.5h2.5V13.25z M6.5,8.5H4V6h2.5V8.5z M11,18H8.5v-2.5H11V18z M11,13.25H8.5v-2.5H11V13.25z M11,8.5H8.5V6H11V8.5z M15.5,18H13v-2.5h2.5V18z M15.5,13.25H13v-2.5h2.5V13.25z M15.5,8.5H13V6 h2.5V8.5z M20,18h-2.5v-2.5H20V18z M20,13.25h-2.5v-2.5H20V13.25z M20,8.5h-2.5V6H20V8.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

