// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionApiRounded : MaterialIcon
{
    public ActionApiRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.6400000000000008, 1.6400000000000008, 20.719999999999999, 20.719999999999999);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0733452593917709, 0, 0, 1.0733452593917709, -0.88014311270125134, -0.88014311270125134);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13,13L13,13c-0.56,0.56-1.45,0.56-2,0.01L11,13c-0.55-0.55-0.55-1.44,0-1.99L11,11c0.55-0.55,1.44-0.55,1.99,0L13,11 C13.55,11.55,13.55,12.45,13,13z M12,6l2.12,2.12l2.5-2.5l-3.2-3.2c-0.78-0.78-2.05-0.78-2.83,0l-3.2,3.2l2.5,2.5L12,6z M6,12 l2.12-2.12l-2.5-2.5l-3.2,3.2c-0.78,0.78-0.78,2.05,0,2.83l3.2,3.2l2.5-2.5L6,12z M18,12l-2.12,2.12l2.5,2.5l3.2-3.2 c0.78-0.78,0.78-2.05,0-2.83l-3.2-3.2l-2.5,2.5L18,12z M12,18l-2.12-2.12l-2.5,2.5l3.2,3.2c0.78,0.78,2.05,0.78,2.83,0l3.2-3.2 l-2.5-2.5L12,18z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

