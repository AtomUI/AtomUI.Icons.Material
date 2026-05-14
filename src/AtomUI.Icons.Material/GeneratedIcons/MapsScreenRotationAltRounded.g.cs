// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsScreenRotationAltRounded : MaterialIcon
{
    public MapsScreenRotationAltRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 1.8099999999999998, 20, 20.380000000000003);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0815682739972963, 0, 0, 1.0815682739972963, -0.97881928796755524, -0.97881928796755524);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18.53,9.29C19.16,9.92,18.71,11,17.82,11c-0.27,0-0.52-0.11-0.71-0.29L10.4,4L5.41,9H7c0.55,0,1,0.45,1,1s-0.45,1-1,1H3 c-0.55,0-1-0.45-1-1V6c0-0.55,0.45-1,1-1s1,0.45,1,1v1.59l5-5c0.78-0.78,2.05-0.78,2.83,0L18.53,9.29z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5.47,14.71C4.84,14.08,5.29,13,6.18,13c0.27,0,0.52,0.11,0.71,0.29L13.6,20l4.99-5H17c-0.55,0-1-0.45-1-1s0.45-1,1-1h4 c0.55,0,1,0.45,1,1v4c0,0.55-0.45,1-1,1s-1-0.45-1-1v-1.59l-5,5c-0.78,0.78-2.05,0.78-2.83,0L5.47,14.71z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

