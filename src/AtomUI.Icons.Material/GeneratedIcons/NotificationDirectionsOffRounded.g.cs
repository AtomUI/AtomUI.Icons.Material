// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class NotificationDirectionsOffRounded : MaterialIcon
{
    public NotificationDirectionsOffRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.1000000000000001, 2.2899999999999991, 19.989999999999995, 19.799999999999997);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1054813450023029, 0, 0, 1.1054813450023029, -1.2657761400276346, -1.2657761400276346);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("m21.71 11.29-9-9a.996.996 0 00-1.41 0L8.21 5.38 13 10.17V7.5l3.15 3.15c.2.2.2.51 0 .71l-.98.98 3.45 3.45 3.09-3.09c.38-.38.38-1.01 0-1.41z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6.79 6.79 3.51 3.51A.996.996 0 102.1 4.92L5.38 8.2l-3.09 3.09a.996.996 0 000 1.41l9 9c.39.39 1.02.39 1.41 0l3.09-3.09 3.28 3.28a.996.996 0 101.41-1.41L6.79 6.79zM9.99 14c0 .55-.45 1-1 1s-1-.45-1-1v-3c0-.05.02-.1.03-.15l1.97 1.97V14z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

