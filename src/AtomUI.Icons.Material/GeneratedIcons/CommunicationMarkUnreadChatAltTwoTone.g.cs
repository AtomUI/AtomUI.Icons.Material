// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class CommunicationMarkUnreadChatAltTwoTone : Icon
{
    public CommunicationMarkUnreadChatAltTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M4,17.17L5.17,16H20V7.9C19.68,7.96,19.34,8,19,8s-0.68-0.04-1-0.1V8H6V6h9.03 c-0.44-0.58-0.77-1.26-0.92-2H4V17.17z M6,9h12v2H6V9z M6,12h8v2H6V12z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Center = new Point(19, 3),
            Radius = 3
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M20,16H5.17L4,17.17V4h10.1c-0.18-0.89-0.08-1.61,0-2H4C2.9,2,2.01,2.9,2.01,4L2,22l4-4h14c1.1,0,2-0.9,2-2V6.97 c-0.58,0.44-1.26,0.77-2,0.92V16z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(6, 12, 8, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Rect = new Rect(6, 9, 12, 2),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M6,8h12V7.9c-1.21-0.25-2.25-0.95-2.97-1.9H6V8z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

