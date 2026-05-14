// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionCalendarViewDayRounded : MaterialIcon
{
    public ActionCalendarViewDayRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5,7h14c1.1,0,2,0.9,2,2v6c0,1.1-0.9,2-2,2H5c-1.1,0-2-0.9-2-2V9C3,7.9,3.9,7,5,7z M4,3h16c0.55,0,1,0.45,1,1v0 c0,0.55-0.45,1-1,1H4C3.45,5,3,4.55,3,4v0C3,3.45,3.45,3,4,3z M4,19h16c0.55,0,1,0.45,1,1v0c0,0.55-0.45,1-1,1H4c-0.55,0-1-0.45-1-1 v0C3,19.45,3.45,19,4,19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

