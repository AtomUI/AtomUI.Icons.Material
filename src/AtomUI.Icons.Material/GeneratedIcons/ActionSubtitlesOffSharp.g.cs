// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionSubtitlesOffSharp : MaterialIcon
{
    public ActionSubtitlesOffSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.04, 2.4500000000000002, 20.960000000000001, 20.510000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0452961672473868, 0, 0, 1.0452961672473868, -0.54355400696864109, -0.54355400696864109);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(6.83, 4),new Avalonia.Point(14.83, 12),new Avalonia.Point(20, 12),new Avalonia.Point(20, 14),new Avalonia.Point(16.83, 14),new Avalonia.Point(22, 19.17),new Avalonia.Point(22, 4)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M1.04,3.87L2,4.83V20h15.17l2.96,2.96l1.41-1.41L2.45,2.45L1.04,3.87z M4,12h4v2H4V12z M4,16h9.17L14,16.83V18H4V16z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

