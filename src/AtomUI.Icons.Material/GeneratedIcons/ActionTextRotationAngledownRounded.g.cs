// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionTextRotationAngledownRounded : MaterialIcon
{
    public ActionTextRotationAngledownRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3.2999999999999994, 3.6099999999999994, 16.380000000000003, 17.389999999999997);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1764705882352937, 0, 0, 1.1764705882352937, -2.1176470588235254, -2.1176470588235254);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M15 20.5v-2.54c0-.45-.54-.67-.85-.35l-.56.56L5.1 9.68c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.02 0 1.41l8.49 8.49-.56.56c-.32.32-.1.86.34.86h2.54c.28 0 .5-.23.5-.5zM11.25 8.48l3.54 3.54-.67 1.6c-.15.36-.07.77.21 1.05.49.49 1.31.32 1.57-.32l3.61-9.09c.17-.42.07-.91-.25-1.23-.32-.32-.8-.42-1.23-.25l-9.1 3.6c-.64.25-.81 1.08-.32 1.57.27.27.68.35 1.04.2l1.6-.67zm6.59-3.05l-2.23 4.87-2.64-2.64 4.87-2.23z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

