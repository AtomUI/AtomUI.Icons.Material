// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Material;

public class ActionHotelClassRounded : MaterialIcon
{
    public ActionHotelClassRounded()
    {
        IconTheme = IconThemeType.Rounded;
        ViewBox = new Rect(0, 0, 24, 24);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 24, 24);
    internal override Rect GeneratedGeometryBounds => new Rect(1.8700000000000001, 3.0999999999999988, 20.939999999999998, 18.260000000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.118881118881119, 0, 0, 1.118881118881119, -1.4265734265734267, -1.4265734265734267);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("M8.58 10H2.56c-.49 0-.69.62-.29.91l4.91 3.51-1.89 6.1c-.14.46.39.84.78.55L11 17.31l4.93 3.75c.39.29.92-.08.78-.55l-1.89-6.1 4.91-3.51c.4-.28.2-.91-.29-.91h-6.02l-1.95-6.42c-.14-.47-.81-.47-.96 0L8.58 10zM20.9 20.51l-1.4-4.52 2.91-2.08c.4-.28.2-.91-.29-.91h-1.88l-3.08 2.2 1.46 4.72 1.5 1.14c.39.29.92-.09.78-.55zM17 8l-1.34-4.42c-.14-.47-.81-.47-.96 0l-.57 1.87.78 2.55H17z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

