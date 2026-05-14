// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionAddchartRounded : MaterialIcon
{
    public ActionAddchartRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 2, 19, 19);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M11,10c0-0.55,0.45-1,1-1s1,0.45,1,1v7h-2V10z M20,13c-0.55,0-1,0.45-1,1v5H5V5h5c0.55,0,1-0.45,1-1c0-0.55-0.45-1-1-1H5 C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2v-5C21,13.45,20.55,13,20,13z M21,5h-2V3c0-0.55-0.45-1-1-1s-1,0.45-1,1v2 h-2c-0.55,0-1,0.45-1,1c0,0.55,0.45,1,1,1h2v2c0,0.55,0.45,1,1,1s1-0.45,1-1V7h2c0.55,0,1-0.45,1-1C22,5.45,21.55,5,21,5z M16,13 c-0.55,0-1,0.45-1,1v3h2v-3C17,13.45,16.55,13,16,13z M7,12v5h2v-5c0-0.55-0.45-1-1-1S7,11.45,7,12z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

