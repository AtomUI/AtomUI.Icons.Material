// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class NavigationLegendToggleRounded : MaterialIcon
{
    public NavigationLegendToggleRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 5, 16, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2, 0, 0, 1.2, -2.3999999999999986, -2.3999999999999986);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19,15H5c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h14c0.55,0,1,0.45,1,1v0C20,14.55,19.55,15,19,15z M19,17H5 c-0.55,0-1,0.45-1,1v0c0,0.55,0.45,1,1,1h14c0.55,0,1-0.45,1-1v0C20,17.45,19.55,17,19,17z M15,11l4.58-3.25 C19.84,7.56,20,7.26,20,6.94v0c0-0.81-0.92-1.29-1.58-0.82L15,8.55L10,5L4.48,8.36C4.18,8.55,4,8.87,4,9.22v0 c0,0.78,0.85,1.26,1.52,0.85l4.4-2.68L15,11z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

