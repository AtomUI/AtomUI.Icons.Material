// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionBrowseGalleryTwoTone : Icon
{
    public ActionBrowseGalleryTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M9,5c-3.86,0-7,3.14-7,7s3.14,7,7,7s7-3.14,7-7S12.86,5,9,5z M11.79,16.21L8,12.41V7h2v4.59l3.21,3.21 L11.79,16.21z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M9,3c-4.97,0-9,4.03-9,9s4.03,9,9,9s9-4.03,9-9S13.97,3,9,3z M9,19c-3.86,0-7-3.14-7-7s3.14-7,7-7s7,3.14,7,7 S12.86,19,9,19z"),
        },
        new PolygonDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Points = [new Point(10, 7),new Point(8, 7),new Point(8, 12.41),new Point(11.79, 16.21),new Point(13.21, 14.79),new Point(10, 11.59)]
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M17.99,3.52v2.16C20.36,6.8,22,9.21,22,12c0,2.79-1.64,5.2-4.01,6.32v2.16C21.48,19.24,24,15.91,24,12 C24,8.09,21.48,4.76,17.99,3.52z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

