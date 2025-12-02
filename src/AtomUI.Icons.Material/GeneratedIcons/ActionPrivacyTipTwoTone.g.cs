// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class ActionPrivacyTipTwoTone : Icon
{
    public ActionPrivacyTipTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,3.19L5,6.3V11c0,4.52,2.98,8.69,7,9.93c4.02-1.23,7-5.41,7-9.93V6.3L12,3.19z M13,17h-2v-6h2V17z M13,9 h-2V7h2V9z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M12,3.19l7,3.11V11c0,4.52-2.98,8.69-7,9.93C7.98,19.69,5,15.52,5,11V6.3L12,3.19 M12,1L3,5v6c0,5.55,3.84,10.74,9,12 c5.16-1.26,9-6.45,9-12V5L12,1L12,1z M11,7h2v2h-2V7z M11,11h2v6h-2V11z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

