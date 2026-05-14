// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionDynamicFormRounded : MaterialIcon
{
    public ActionDynamicFormRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 4, 19.859999999999999, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -1.0909090909090899, -1.0909090909090899);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M21.68,9.71l-3.72,8.19C17.73,18.39,17,18.23,17,17.69V11h-1.5c-0.28,0-0.5-0.22-0.5-0.5v-6C15,4.22,15.22,4,15.5,4h5.76 c0.35,0,0.6,0.36,0.46,0.69L20,9h1.22C21.59,9,21.83,9.38,21.68,9.71z M15,13v7H4c-1.1,0-2-0.9-2-2v-3c0-1.1,0.9-2,2-2H15z M6.25,16.5c0-0.41-0.34-0.75-0.75-0.75s-0.75,0.34-0.75,0.75c0,0.41,0.34,0.75,0.75,0.75S6.25,16.91,6.25,16.5z M13,4v7H4 c-1.1,0-2-0.9-2-2V6c0-1.1,0.9-2,2-2H13z M6.25,7.5c0-0.41-0.34-0.75-0.75-0.75S4.75,7.09,4.75,7.5c0,0.41,0.34,0.75,0.75,0.75 S6.25,7.91,6.25,7.5z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

