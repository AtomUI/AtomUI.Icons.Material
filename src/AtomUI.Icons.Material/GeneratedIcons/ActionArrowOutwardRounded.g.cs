// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionArrowOutwardRounded : MaterialIcon
{
    public ActionArrowOutwardRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(5.3199999999999994, 6, 12.68, 12.680000000000003);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2847965738758029, 0, 0, 1.2847965738758029, -3.4175588865096351, -3.4175588865096351);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6,7L6,7c0,0.55,0.45,1,1,1h7.59l-8.88,8.88c-0.39,0.39-0.39,1.02,0,1.41l0,0c0.39,0.39,1.02,0.39,1.41,0L16,9.41V17 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V7c0-0.55-0.45-1-1-1H7C6.45,6,6,6.45,6,7z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

