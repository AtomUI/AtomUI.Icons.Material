// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceSignalWifiConnectedNoInternet0TwoTone : MaterialIcon
{
    public DeviceSignalWifiConnectedNoInternet0TwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 4, 24, 17);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M24,8.98C20.93,5.9,16.69,4,12,4C7.31,4,3.07,5.9,0,8.98L12,21v-9h8.99L24,8.98z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Avalonia.Point(19.59, 14),new Avalonia.Point(17.5, 16.09),new Avalonia.Point(17.2, 15.79),new Avalonia.Point(15.41, 14),new Avalonia.Point(14, 15.41),new Avalonia.Point(15.79, 17.2),new Avalonia.Point(16.09, 17.5),new Avalonia.Point(14, 19.59),new Avalonia.Point(15.41, 21),new Avalonia.Point(17.5, 18.92),new Avalonia.Point(19.59, 21),new Avalonia.Point(21, 19.59),new Avalonia.Point(18.92, 17.5),new Avalonia.Point(21, 15.41)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

