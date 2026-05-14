// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionThumbUpOffAltRounded : MaterialIcon
{
    public ActionThumbUpOffAltRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.47, 22.940000000000001, 19.530000000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0075566750629721, 0, 0, 1.0075566750629721, -0.090680100755665904, -0.090680100755665904);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M13.12,2.06L7.58,7.6C7.21,7.97,7,8.48,7,9.01V19c0,1.1,0.9,2,2,2h9c0.8,0,1.52-0.48,1.84-1.21l3.26-7.61 C23.94,10.2,22.49,8,20.34,8h-5.65l0.95-4.58c0.1-0.5-0.05-1.01-0.41-1.37C14.64,1.47,13.7,1.47,13.12,2.06z M3,21 c1.1,0,2-0.9,2-2v-8c0-1.1-0.9-2-2-2s-2,0.9-2,2v8C1,20.1,1.9,21,3,21z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

