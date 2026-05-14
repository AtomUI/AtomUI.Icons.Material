// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class EditorMergeTypeRounded : MaterialIcon
{
    public EditorMergeTypeRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5.9000000000000004, 3.6600000000000001, 12.19, 16.43);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1799410029498525, 0, 0, 1.1799410029498525, -2.1592920353982308, -2.1592920353982308);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M17.7 19.7c.39-.39.39-1.02 0-1.41l-2.7-2.7L13.59 17l2.7 2.7c.39.39 1.03.39 1.41 0zM8.71 8H11v5.59l-4.71 4.7c-.39.39-.39 1.02 0 1.41.39.39 1.02.39 1.41 0l4.71-4.7c.38-.38.59-.88.59-1.41V8h2.29c.45 0 .67-.54.35-.85l-3.29-3.29c-.2-.2-.51-.2-.71 0L8.35 7.15c-.31.31-.09.85.36.85z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

