// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class NotificationSimCardAlertRounded : MaterialIcon
{
    public NotificationSimCardAlertRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 2, 16, 20);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,2h-7.17C10.3,2,9.79,2.21,9.41,2.59L4.6,7.42C4.23,7.79,4.02,8.3,4.02,8.82L4,20c0,1.1,0.9,2,2,2h12c1.1,0,2-0.9,2-2 V4C20,2.9,19.1,2,18,2z M12,17L12,17c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h0c0.55,0,1,0.45,1,1v0C13,16.55,12.55,17,12,17z M12,13L12,13c-0.55,0-1-0.45-1-1V9c0-0.55,0.45-1,1-1l0,0c0.55,0,1,0.45,1,1v3C13,12.55,12.55,13,12,13z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

