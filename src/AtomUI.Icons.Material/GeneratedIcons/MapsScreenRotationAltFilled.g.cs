// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class MapsScreenRotationAltFilled : MaterialIcon
{
    public MapsScreenRotationAltFilled()
    {
        IconTheme = IconThemeType.Filled;
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
            Data = StreamGeometry.Parse("M4,7.59l5-5c0.78-0.78,2.05-0.78,2.83,0L20.24,11h-2.83L10.4,4L5.41,9H8v2H2V5h2V7.59z M20,19h2v-6h-6v2h2.59l-4.99,5 l-7.01-7H3.76l8.41,8.41c0.78,0.78,2.05,0.78,2.83,0l5-5V19z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

