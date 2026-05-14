// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionSpatialTrackingRounded : MaterialIcon
{
    public ActionSpatialTrackingRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 1.3300000000000001, 20.629999999999999, 19.670000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.05866784296427, 0, 0, 1.05866784296427, -0.7040141155712405, -0.7040141155712405);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(10, 9),
            Radius = 4
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M16.39,15.56C14.71,14.7,12.53,14,10,14c-2.53,0-4.71,0.7-6.39,1.56C2.61,16.07,2,17.1,2,18.22V21h16v-2.78 C18,17.1,17.39,16.07,16.39,15.56z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19.39,1.76L19.39,1.76c-0.43-0.43-1.14-0.39-1.51,0.09c-1.5,1.93-3.35,6.72,0,11.03c0.37,0.48,1.08,0.52,1.5,0.09l0,0 c0.35-0.35,0.39-0.91,0.09-1.3c-1.17-1.5-2.64-5.23,0-8.61C19.78,2.67,19.74,2.11,19.39,1.76z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22.4,5.86c0.23-0.4,0.19-0.9-0.14-1.22l0,0C21.79,4.16,21,4.27,20.67,4.85c-1.15,2-0.57,4.03,0.01,5.04 c0.33,0.57,1.11,0.67,1.58,0.21c0.33-0.33,0.36-0.84,0.13-1.25C22.14,8.41,21.65,7.16,22.4,5.86z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

