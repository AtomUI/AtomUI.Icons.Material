// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionUpgradeRounded : MaterialIcon
{
    public ActionUpgradeRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(8, 4.1700000000000008, 8, 15.829999999999998);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2207527975584946, 0, 0, 1.2207527975584946, -2.6490335707019348, -2.6490335707019348);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M16,19L16,19c0,0.55-0.45,1-1,1H9c-0.55,0-1-0.45-1-1v0c0-0.55,0.45-1,1-1h6C15.55,18,16,18.45,16,19z M11,7.99V15 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V7.99h1.79c0.45,0,0.67-0.54,0.35-0.85l-2.79-2.78c-0.2-0.19-0.51-0.19-0.71,0L8.86,7.14 C8.54,7.45,8.76,7.99,9.21,7.99H11z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

