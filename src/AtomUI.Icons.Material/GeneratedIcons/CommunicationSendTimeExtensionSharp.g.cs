// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class CommunicationSendTimeExtensionSharp : Icon
{
    public CommunicationSendTimeExtensionSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,4h-6c0-1.38-1.12-2.5-2.5-2.5S9,2.62,9,4H3.01v5.8C5.7,9.8,6,11.96,6,12.5c0,0.54-0.29,2.7-3,2.7V21h5.8 c0-2.16,1.37-2.78,2.2-2.94v-9.3l9,4.5V4z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Points = [new Point(13, 12),new Point(13, 16),new Point(17, 17),new Point(13, 18),new Point(13, 22),new Point(23, 17)]
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

