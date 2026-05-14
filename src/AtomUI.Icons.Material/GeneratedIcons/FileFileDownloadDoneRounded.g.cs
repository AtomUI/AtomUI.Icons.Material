// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class FileFileDownloadDoneRounded : MaterialIcon
{
    public FileFileDownloadDoneRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(4.1900000000000004, 4.3200000000000003, 15.629999999999999, 15.68);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.2232415902140674, 0, 0, 1.2232415902140674, -2.6788990825688082, -2.6788990825688082);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19.42,4.71L19.42,4.71c-0.39-0.39-1.02-0.39-1.41,0l-8.48,8.49L5.99,9.66c-0.39-0.39-1.02-0.39-1.41,0l0,0 c-0.39,0.39-0.39,1.02,0,1.41l4.24,4.24c0.39,0.39,1.02,0.39,1.41,0l9.19-9.19C19.82,5.73,19.82,5.1,19.42,4.71z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M6,20h12c0.55,0,1-0.45,1-1v0c0-0.55-0.45-1-1-1H6c-0.55,0-1,0.45-1,1v0C5,19.55,5.45,20,6,20z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

