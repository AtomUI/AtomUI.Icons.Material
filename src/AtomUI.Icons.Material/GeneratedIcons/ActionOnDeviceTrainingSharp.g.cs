// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionOnDeviceTrainingSharp : MaterialIcon
{
    public ActionOnDeviceTrainingSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 1, 16, 22);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -0.52173913043478137, -0.52173913043478137);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Rect = new Rect(11, 16, 2, 1),
            RadiusX = 0,
            RadiusY = 0,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M12,11c-1.1,0-2,0.9-2,2c0,0.74,0.4,1.38,1,1.72v0.78h2v-0.78c0.6-0.35,1-0.98,1-1.72C14,11.9,13.1,11,12,11z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M20,1.01L4,1v22h16V1.01z M18,18H6V6h12V18z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M16.01,15.95C16.63,15.12,17,14.11,17,13s-0.37-2.12-0.99-2.95l-1.07,1.07c0.35,0.54,0.56,1.19,0.56,1.88 s-0.21,1.34-0.56,1.88L16.01,15.95z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M9.06,14.88C8.71,14.34,8.5,13.69,8.5,13c0-1.93,1.57-3.5,3.5-3.5v1.25l2.25-2l-2.25-2V8c-2.76,0-5,2.24-5,5 c0,1.11,0.37,2.12,0.99,2.95L9.06,14.88z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

