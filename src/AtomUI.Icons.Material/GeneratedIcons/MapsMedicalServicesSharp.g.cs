// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.Material;

public class MapsMedicalServicesSharp : Icon
{
    public MapsMedicalServicesSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M16,6V2H8v4H2v16h20V6H16z M10,4h4v2h-4V4z M16,15h-3v3h-2v-3H8v-2h3v-3h2v3h3V15z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

