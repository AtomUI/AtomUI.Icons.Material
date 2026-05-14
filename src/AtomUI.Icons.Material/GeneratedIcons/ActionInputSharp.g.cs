// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionInputSharp : MaterialIcon
{
    public ActionInputSharp()
    {
        IconTheme = IconThemeType.Sharp;
        ViewBox = new Rect(0, 0, 1024, 1024);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 1024, 1024);
    internal override Rect GeneratedGeometryBounds => new Rect(91.428571000000005, 146.28571400000001, 841.14285800000005, 731.42857200000003);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0980392151816611, 0, 0, 1.0980392151816611, -50.196078173010505, -50.196078173010505);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M932.571429 146.285714v731.428572H91.428571V640h73.142858v164.571429h694.857142V219.428571H164.571429v164.571429H91.428571V146.285714h841.142858zM530.285714 365.714286l164.571429 146.285714-164.571429 146.285714v-109.714285H91.428571v-73.142858h438.857143v-109.714285z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

