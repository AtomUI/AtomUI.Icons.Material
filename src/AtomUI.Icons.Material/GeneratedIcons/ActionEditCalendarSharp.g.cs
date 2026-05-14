// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionEditCalendarSharp : MaterialIcon
{
    public ActionEditCalendarSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 2, 20.539999999999999, 21);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0610079575596818, 0, 0, 1.0610079575596818, -0.73209549071618163, -0.73209549071618163);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,22H3V4h3V2h2v2h8V2h2v2h3v8h-2v-2H5v10h7V22z M22.13,16.99l1.41-1.41l-2.12-2.12l-1.41,1.41L22.13,16.99z M21.42,17.7 l-5.3,5.3H14v-2.12l5.3-5.3L21.42,17.7z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

