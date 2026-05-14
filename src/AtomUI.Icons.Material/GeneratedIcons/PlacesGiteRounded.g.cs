// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesGiteRounded : MaterialIcon
{
    public PlacesGiteRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 4, 20, 15);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21.41,9.41l-2.83-2.83C18.21,6.21,17.7,6,17.17,6H9V5c0-0.55-0.45-1-1-1S7,4.45,7,5v1H6.83C6.3,6,5.79,6.21,5.41,6.59 L2.59,9.41C2.21,9.79,2,10.3,2,10.83V17c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2v-6.17C22,10.3,21.79,9.79,21.41,9.41z M14,17H4v-5h10 V17z M20,17h-4v-6.17l2-2l2,2V17z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

