// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class CommunicationMarkUnreadChatAltRounded : MaterialIcon
{
    public CommunicationMarkUnreadChatAltRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 0, 20, 20.919999999999998);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Center = new Avalonia.Point(19, 3),
            Radius = 3
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M7,8C6.45,8,6,7.55,6,7c0-0.55,0.45-1,1-1h8.03c-1.21-1.6-1.08-3.21-0.92-4H4.01c-1.1,0-2,0.89-2,2L2,19.58 c0,0.89,1.08,1.34,1.71,0.71L6,18h14c1.1,0,2-0.9,2-2V6.97C21.16,7.61,20.13,8,19,8H7z M13,14H7c-0.55,0-1-0.45-1-1 c0-0.55,0.45-1,1-1h6c0.55,0,1,0.45,1,1C14,13.55,13.55,14,13,14z M17,11H7c-0.55,0-1-0.45-1-1c0-0.55,0.45-1,1-1h10 c0.55,0,1,0.45,1,1C18,10.55,17.55,11,17,11z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

