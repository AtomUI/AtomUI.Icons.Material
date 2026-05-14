// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class PlacesHouseSidingRounded : MaterialIcon
{
    public PlacesHouseSidingRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(2.6299999999999999, 3.2600000000000002, 18.75, 16.739999999999998);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1235955056179774, 0, 0, 1.1235955056179774, -1.4831460674157277, -1.4831460674157277);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M19,12h1.7c0.46,0,0.68-0.57,0.33-0.87L12.67,3.6c-0.38-0.34-0.96-0.34-1.34,0l-8.36,7.53C2.63,11.43,2.84,12,3.3,12H5v7 c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1v-1h10v1c0,0.55,0.45,1,1,1h0c0.55,0,1-0.45,1-1V12z M7.21,10h9.58L17,10.19V12H7v-1.81 L7.21,10z M14.57,8H9.43L12,5.69L14.57,8z M7,16v-2h10v2H7z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

