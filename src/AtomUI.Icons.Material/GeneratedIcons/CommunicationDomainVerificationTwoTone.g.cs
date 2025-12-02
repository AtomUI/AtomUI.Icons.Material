// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class CommunicationDomainVerificationTwoTone : Icon
{
    public CommunicationDomainVerificationTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5,18h14V8H5V18z M8.82,11.58l2.12,2.12l4.24-4.24l1.41,1.41l-5.66,5.66L7.4,13L8.82,11.58z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(16.6, 10.88),new Point(15.18, 9.46),new Point(10.94, 13.71),new Point(8.82, 11.58),new Point(7.4, 13),new Point(10.94, 16.54)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19,4H5C3.89,4,3,4.9,3,6v12c0,1.1,0.89,2,2,2h14c1.1,0,2-0.9,2-2V6C21,4.9,20.11,4,19,4z M19,18H5V8h14V18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

