// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class FileTopicSharp : Icon
{
    public FileTopicSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,6l-2-2H2v16h20V6H12z M14,16H6v-2h8V16z M18,12H6v-2h12V12z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

