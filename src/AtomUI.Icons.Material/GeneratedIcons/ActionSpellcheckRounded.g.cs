// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionSpellcheckRounded : MaterialIcon
{
    public ActionSpellcheckRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.73, 3, 19.949999999999999, 19.190000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1976047904191618, 0, 0, 1.1976047904191618, -2.3712574850299415, -2.3712574850299415);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13.12 16c.69 0 1.15-.69.9-1.32L9.77 3.87C9.56 3.34 9.06 3 8.5 3s-1.06.34-1.27.87L2.98 14.68c-.25.63.22 1.32.9 1.32.4 0 .76-.25.91-.63L5.67 13h5.64l.9 2.38c.15.37.51.62.91.62zm-6.69-5L8.5 5.48 10.57 11H6.43zm14.46 1.29l-7.39 7.39-2.97-2.97c-.39-.39-1.02-.39-1.41 0-.39.39-.39 1.02 0 1.41l3.68 3.68c.39.39 1.02.39 1.41 0l8.08-8.09c.39-.39.39-1.02 0-1.41-.38-.39-1.02-.39-1.4-.01z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

