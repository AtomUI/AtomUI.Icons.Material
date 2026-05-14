// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ImageDetailsRounded : MaterialIcon
{
    public ImageDetailsRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.46, 3.8900000000000001, 19.079999999999998, 17.109999999999999);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1142061281337048, 0, 0, 1.1142061281337048, -1.3704735376044574, -1.3704735376044574);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M11.13,4.57l-8.3,14.94C2.46,20.18,2.94,21,3.7,21h16.6c0.76,0,1.24-0.82,0.87-1.49l-8.3-14.94 C12.49,3.89,11.51,3.89,11.13,4.57z M13,8.92L18.6,19H13V8.92z M11,8.92V19H5.4L11,8.92z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

