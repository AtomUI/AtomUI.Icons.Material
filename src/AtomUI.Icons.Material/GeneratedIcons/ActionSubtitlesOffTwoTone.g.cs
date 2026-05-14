// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionSubtitlesOffTwoTone : MaterialIcon
{
    public ActionSubtitlesOffTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.04, 2.4500000000000002, 20.960000000000001, 20.510000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0452961672473868, 0, 0, 1.0452961672473868, -0.54355400696864109, -0.54355400696864109);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(8.83, 6),new Avalonia.Point(12.83, 10),new Avalonia.Point(18, 10),new Avalonia.Point(18, 12),new Avalonia.Point(14.83, 12),new Avalonia.Point(20, 17.17),new Avalonia.Point(20, 6)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Points = [new Avalonia.Point(15.17, 18),new Avalonia.Point(13.17, 16),new Avalonia.Point(6, 16),new Avalonia.Point(6, 14),new Avalonia.Point(11.17, 14),new Avalonia.Point(8, 10.83),new Avalonia.Point(8, 12),new Avalonia.Point(6, 12),new Avalonia.Point(6, 10),new Avalonia.Point(7.17, 10),new Avalonia.Point(4, 6.83),new Avalonia.Point(4, 18)]
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(18, 10),new Avalonia.Point(12.83, 10),new Avalonia.Point(14.83, 12),new Avalonia.Point(18, 12)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,4H6.83l2,2H20v11.17l1.76,1.76C21.91,18.65,22,18.34,22,18V6C22,4.9,21.1,4,20,4z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M1.04,3.87l1.2,1.2C2.09,5.35,2,5.66,2,6v12c0,1.1,0.9,2,2,2h13.17l2.96,2.96l1.41-1.41L2.45,2.45L1.04,3.87z M4,6.83 L7.17,10H6v2h2v-1.17L11.17,14H6v2h7.17l2,2H4V6.83z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

