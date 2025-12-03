// This code is auto generated. Do not modify.
// Generated Date: 2025-12-03

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class CommunicationMarkUnreadChatAltFilled : Icon
{
    public CommunicationMarkUnreadChatAltFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Point(19, 3),
            Radius = 3
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6,8V6h9.03c-1.21-1.6-1.08-3.21-0.92-4H4.01c-1.1,0-2,0.89-2,2L2,22l4-4h14c1.1,0,2-0.9,2-2V6.97 C21.16,7.61,20.13,8,19,8H6z M14,14H6v-2h8V14z M18,11H6V9h12V11z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

