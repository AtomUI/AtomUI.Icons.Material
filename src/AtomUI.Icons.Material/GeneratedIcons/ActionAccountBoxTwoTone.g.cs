// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionAccountBoxTwoTone : MaterialIcon
{
    public ActionAccountBoxTwoTone()
    {
        IconTheme = IconThemeType.TwoTone;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(3, 3, 18, 18);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -1.7142857142857135, -1.7142857142857135);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 0.3,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M5,17.86C6.8,16.09,9.27,15,12,15s5.2,1.09,7,2.86V5H5V17.86z M12,6 c1.93,0,3.5,1.57,3.5,3.5S13.93,13,12,13c-1.93,0-3.5-1.57-3.5-3.5S10.07,6,12,6z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M19,3H5C3.9,3,3,3.9,3,5v14c0,1.1,0.9,2,2,2h14c1.1,0,2-0.9,2-2V5C21,3.9,20.1,3,19,3z M17,19H7v-0.24 C8.42,17.62,10.16,17,12,17s3.58,0.62,5,1.76V19z M19,17.86C17.2,16.09,14.73,15,12,15s-5.2,1.09-7,2.86V5h14V17.86z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            Data = StreamGeometry.Parse("M12,13c1.93,0,3.5-1.57,3.5-3.5S13.93,6,12,6c-1.93,0-3.5,1.57-3.5,3.5S10.07,13,12,13z M12,8c0.83,0,1.5,0.67,1.5,1.5 S12.83,11,12,11s-1.5-0.67-1.5-1.5S11.17,8,12,8z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

