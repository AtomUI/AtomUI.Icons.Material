// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class DeviceScreenSearchDesktopSharp : Icon
{
    public DeviceScreenSearchDesktopSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(1, 19, 22, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M22,3H2v15h19.99L22,3z M15.47,15.03l-2.09-2.09c-1.35,0.87-3.17,0.71-4.36-0.47c-1.37-1.37-1.37-3.58,0-4.95 s3.58-1.37,4.95,0c1.18,1.18,1.34,3,0.47,4.36l2.09,2.09L15.47,15.03z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Point(11.5, 10),
            Radius = 2
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

