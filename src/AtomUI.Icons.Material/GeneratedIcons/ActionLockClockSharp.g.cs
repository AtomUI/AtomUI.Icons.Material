// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionLockClockSharp : MaterialIcon
{
    public ActionLockClockSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 0.73999999999999999, 19, 22.260000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0318142734307825, 0, 0, 1.0318142734307825, -0.38177128116938874, -0.38177128116938874);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,11c0.7,0,1.37,0.1,2,0.29V8h-3V6.21c0-2.61-1.91-4.94-4.51-5.19C9.51,0.74,7,3.08,7,6v2H4v14h8.26 C11.47,20.87,11,19.49,11,18C11,14.13,14.13,11,18,11z M9,6c0-1.66,1.34-3,3-3s3,1.34,3,3v2H9V6z M18,13c-2.76,0-5,2.24-5,5 s2.24,5,5,5s5-2.24,5-5S20.76,13,18,13z M19.65,20.35l-2.15-2.15V15h1v2.79l1.85,1.85L19.65,20.35z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

