using AtomUI.Controls;
using Avalonia;

namespace AtomUI.Icons.Material;

public class MaterialIcon : Icon
{
    private Rect? _geometryBounds;

    internal virtual bool HasGeneratedGeometryMetadata => false;
    internal virtual Rect GeneratedViewBox => default;
    internal virtual Rect GeneratedGeometryBounds => default;
    internal virtual Matrix GeneratedZoomMatrix => Matrix.Identity;

    protected override Matrix CalculateGlobalGeometryMatrix()
    {
        if (HasGeneratedGeometryMetadata)
        {
            return GeneratedViewBox.Equals(ViewBox)
                ? GeneratedZoomMatrix
                : CalculateZoomToFit(ViewBox, GeneratedGeometryBounds);
        }

        _geometryBounds ??= CalculateGeometryBounds();
        return CalculateZoomToFit(ViewBox, _geometryBounds ?? default);
    }

    private static Matrix CalculateZoomToFit(Rect viewbox, Rect iconBounds)
    {
        var viewboxCenter = new Avalonia.Point(
            viewbox.Left + viewbox.Width / 2,
            viewbox.Top + viewbox.Height / 2
        );

        var leftDelta   = iconBounds.Left - viewbox.Left;
        var rightDelta  = viewbox.Right - iconBounds.Right;
        var topDelta    = iconBounds.Top - viewbox.Top;
        var bottomDelta = viewbox.Bottom - iconBounds.Bottom;

        var minDelta = leftDelta;
        if (rightDelta < minDelta)
        {
            minDelta = rightDelta;
        }

        if (topDelta < minDelta)
        {
            minDelta = topDelta;
        }

        if (bottomDelta < minDelta)
        {
            minDelta = bottomDelta;
        }

        minDelta /= 2;

        var iconLeftDist   = iconBounds.Left - viewboxCenter.X - minDelta;
        var iconRightDist  = iconBounds.Right - viewboxCenter.X - minDelta;
        var iconTopDist    = iconBounds.Top - viewboxCenter.Y - minDelta;
        var iconBottomDist = iconBounds.Bottom - viewboxCenter.Y - minDelta;

        var viewboxLeftDist   = viewbox.Left - viewboxCenter.X;
        var viewboxRightDist  = viewbox.Right - viewboxCenter.X;
        var viewboxTopDist    = viewbox.Top - viewboxCenter.Y;
        var viewboxBottomDist = viewbox.Bottom - viewboxCenter.Y;

        var maxScale = double.MaxValue;

        if (Math.Abs(iconLeftDist) > 0.0001)
        {
            var scaleLeft = viewboxLeftDist / iconLeftDist;
            if (scaleLeft > 0 && scaleLeft < maxScale)
            {
                maxScale = scaleLeft;
            }
        }

        if (Math.Abs(iconRightDist) > 0.0001)
        {
            var scaleRight = viewboxRightDist / iconRightDist;
            if (scaleRight > 0 && scaleRight < maxScale)
            {
                maxScale = scaleRight;
            }
        }

        if (Math.Abs(iconTopDist) > 0.0001)
        {
            var scaleTop = viewboxTopDist / iconTopDist;
            if (scaleTop > 0 && scaleTop < maxScale)
            {
                maxScale = scaleTop;
            }
        }

        if (Math.Abs(iconBottomDist) > 0.0001)
        {
            var scaleBottom = viewboxBottomDist / iconBottomDist;
            if (scaleBottom > 0 && scaleBottom < maxScale)
            {
                maxScale = scaleBottom;
            }
        }

        if (maxScale > 1000 || maxScale <= 0)
        {
            maxScale = 1.0;
        }

        var transform = Matrix.Identity;
        transform *= Matrix.CreateTranslation(-viewboxCenter.X, -viewboxCenter.Y);
        transform *= Matrix.CreateScale(maxScale, maxScale);
        transform *= Matrix.CreateTranslation(viewboxCenter.X, viewboxCenter.Y);

        return transform;
    }
}
