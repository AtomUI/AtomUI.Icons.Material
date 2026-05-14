// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class DeviceNearbyErrorRounded : MaterialIcon
{
    public DeviceNearbyErrorRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.8, 1.8, 20.199999999999999, 20.400000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0810810810810814, 0, 0, 1.0810810810810814, -0.97297297297297547, -0.97297297297297547);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M11.29,8.28l-3.01,3.01c-0.39,0.39-0.39,1.02,0,1.41l3.01,3.01c0.39,0.39,1.02,0.39,1.41,0l3.01-3.01 c0.39-0.39,0.39-1.02,0-1.41l-3.01-3.01C12.32,7.89,11.68,7.89,11.29,8.28z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M10.59,2.59l-8.01,8c-0.78,0.78-0.78,2.05,0,2.83l8.01,8c0.78,0.78,2.05,0.78,2.83,0L18,16.82V13.2l-6,6L4.79,12L12,4.79 l6,6V7.17l-4.58-4.58C12.64,1.8,11.37,1.8,10.59,2.59z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,11v6c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-6c0-0.55-0.45-1-1-1h0C20.45,10,20,10.45,20,11z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(21, 21),
            Radius = 1
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

