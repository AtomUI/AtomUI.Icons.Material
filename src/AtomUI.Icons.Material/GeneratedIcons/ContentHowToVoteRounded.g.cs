// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ContentHowToVoteRounded : MaterialIcon
{
    public ContentHowToVoteRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 2.3099999999999996, 18, 19.690000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1225444340505144, 0, 0, 1.1225444340505144, -1.4705332086061738, -1.4705332086061738);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M18,12.18l-1.5,1.64l2,2.18h-13l2-2.18L6,12.18l-3,3.27V20c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2v-4.54L18,12.18z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M10.59,14.42c0.78,0.79,2.05,0.8,2.84,0.01l4.98-4.98c0.78-0.78,0.78-2.05,0-2.83l-3.54-3.53c-0.78-0.78-2.05-0.78-2.83,0 L7.09,8.04c-0.78,0.78-0.78,2.03-0.01,2.82L10.59,14.42z M13.46,4.5l3.53,3.53l-4.94,4.94L8.52,9.44L13.46,4.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

