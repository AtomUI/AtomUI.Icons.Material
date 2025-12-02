// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class PlacesNoMeetingRoomTwoTone : Icon
{
    public PlacesNoMeetingRoomTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12 5H8.12L12 8.88V6zM7 19h5v-4.46l-5-5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M12 5v3.88l2 2V6h3v7.88l2 2V4h-5V3H6.12l2 2zM2.41 2.13L1 3.54l4 4V19H3v2h11v-4.46L20.46 23l1.41-1.41L2.41 2.13zM12 19H7V9.54l5 5V19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

