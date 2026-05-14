using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using AtomUI.Controls;
using AtomUI.Media;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Headless;
using Avalonia.Media;

namespace AtomUI.Icons.Material.Generator;

public class MaterialIconsPackageGenerator : DefaultIconPackageGenerator
{
    public MaterialIconsPackageGenerator(string sourcePath, string targetPath)
        : base(sourcePath, targetPath)
    {
        PackageName              = "Material";
        PackageNamespace         = "AtomUI.Icons.Material";
    }
    
    public static async Task<int> Main(string[] args)
    {
        try
        {
            SetupAvalonia();
            var targetProjectPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../src/AtomUI.Icons.Material"));
            var sourceProjectPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../src/AtomUI.Icons.Material.Generator"));
            var sourcePath        = Path.Combine(sourceProjectPath, "Assets");
            var generator         = new MaterialIconsPackageGenerator(sourcePath, targetProjectPath);
            await generator.GenerateAsync();
            return 0;
        }
        catch  (Exception e)
        {
            Console.Error.WriteLine($"Generate error: {e.Message}");
#if DEBUG
            throw;
#endif
            return 1;
        }
    }

    private static void SetupAvalonia()
    {
        AppBuilder.Configure<GeneratorApplication>()
                  .UseHeadless(new AvaloniaHeadlessPlatformOptions())
                  .SetupWithLifetime(new ClassicDesktopStyleApplicationLifetime());
        SynchronizationContext.SetSynchronizationContext(null);
    }
    
    protected override IEnumerable<IconFileInfo> ScanIconFilesRecursively(string sourcePath)
    {
        foreach (var svgFilePath in Directory.EnumerateFiles(sourcePath,  "24px.svg"))
        {
            var themeType = IconThemeType.Filled;
            var themeTypeDir = Path.GetDirectoryName(svgFilePath);
            var iconBaseNameDir = Path.GetDirectoryName(themeTypeDir);
            var categoryNameDir = Path.GetDirectoryName(iconBaseNameDir);
            Debug.Assert(themeTypeDir != null);
            Debug.Assert(iconBaseNameDir != null);
            Debug.Assert(categoryNameDir != null);
            
            var themeTypeName = Path.GetFileNameWithoutExtension(themeTypeDir);
            var iconBaseName = Path.GetFileNameWithoutExtension(iconBaseNameDir);
            var categoryName = Path.GetFileNameWithoutExtension(categoryNameDir);
            categoryName = CapitalizeFirstLetter(categoryName);
            if (themeTypeName.EndsWith("outlined", StringComparison.OrdinalIgnoreCase))
            {
                themeType = IconThemeType.Outlined;
            }
            else if (themeTypeName.EndsWith("round", StringComparison.OrdinalIgnoreCase))
            {
                themeType = IconThemeType.Rounded;
            }
            else if (themeTypeName.EndsWith("sharp", StringComparison.OrdinalIgnoreCase))
            {
                themeType = IconThemeType.Sharp;
            }
            else if (themeTypeName.EndsWith("twotone", StringComparison.OrdinalIgnoreCase))
            {
                themeType = IconThemeType.TwoTone;
            }

            var name = categoryName + CapitalizeFirstLetter(iconBaseName);
            name = Regex.Replace(name, @"[-_]([a-zA-Z0-9])",
                match => match.Groups[1].ToString().ToUpper());
            
            Debug.Assert(!string.IsNullOrEmpty(themeTypeDir));
            yield return new IconFileInfo()
            {
                Category = categoryName,
                Name = name,
                FilePath = svgFilePath,
                ThemeType = themeType
            };
        }
        
        foreach (var subPath in Directory.EnumerateDirectories(sourcePath))
        {
            foreach (var svgFilePath in ScanIconFilesRecursively(subPath))
            {
                yield return svgFilePath;
            }
        }
    }

    protected override async Task GenerateIconPackageClass(IconFileInfo iconFileInfo, Stream output)
    {
        var sourceText = new StringBuilder();
        sourceText.AppendLine("// This code is auto generated. Do not modify.");
        sourceText.AppendLine("");
        sourceText.AppendLine("using System.Collections.Generic;");
        sourceText.AppendLine("using Avalonia;");
        sourceText.AppendLine("using Avalonia.Media;");
        sourceText.AppendLine("using AtomUI.Controls;");
        sourceText.AppendLine($"namespace {PackageNamespace};");
        sourceText.AppendLine("");
        var svgSource     = await File.ReadAllTextAsync(iconFileInfo.FilePath);
        var    svgParsedInfo = SvgParser.Parse(svgSource);
        var    viewBox       = svgParsedInfo.ViewBox;
        var    viewBoxRect   = new Rect(viewBox.X, viewBox.Y, viewBox.Width, viewBox.Height);
        var    geometryBounds = CalculateGeometryBounds(svgParsedInfo);
        var    zoomMatrix     = CalculateZoomToFit(viewBoxRect, geometryBounds);
        var    className     = $"{iconFileInfo.Name}{iconFileInfo.ThemeType}";
        
        sourceText.AppendLine($"public class {className} : MaterialIcon");
        sourceText.AppendLine(@"{");
        sourceText.AppendLine($"    public {className}()");
        sourceText.AppendLine(@"    {");
        sourceText.AppendLine($"        IconTheme = IconThemeType.{iconFileInfo.ThemeType};");
        sourceText.AppendLine($"        ViewBox = {FormatRect(viewBoxRect)};");
        sourceText.AppendLine(@"    }");
        sourceText.AppendLine(@"");
        sourceText.AppendLine(@"    internal override bool HasGeneratedGeometryMetadata => true;");
        sourceText.AppendLine($"    internal override Rect GeneratedViewBox => {FormatRect(viewBoxRect)};");
        sourceText.AppendLine($"    internal override Rect GeneratedGeometryBounds => {FormatRect(geometryBounds)};");
        sourceText.AppendLine($"    internal override Matrix GeneratedZoomMatrix => {FormatMatrix(zoomMatrix)};");
        sourceText.AppendLine(@"");
        sourceText.AppendLine(@"    private static readonly DrawingInstruction[] StaticInstructions = [");
        var graphicElementCount = svgParsedInfo.GraphicElements.Count;
        var effectiveGraphicElementCount = graphicElementCount;

        for (var i = 0; i < graphicElementCount; i++)
        {
            var graphicElement  = svgParsedInfo.GraphicElements[i];
            if (graphicElement.FillColor == "none")
            {
                --effectiveGraphicElementCount;
            }
        }

        for (var i = 0; i < graphicElementCount; i++)
        {
            var graphicElement  = svgParsedInfo.GraphicElements[i];
            if (graphicElement.FillColor == "none")
            {
                continue;
            }
            if (graphicElement is RectElement rectElement)
            {
                sourceText.AppendLine(@"        new RectDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, rectElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Rect = new Rect({rectElement.X}, {rectElement.Y}, {rectElement.Width}, {rectElement.Height}),");
                sourceText.AppendLine($"            RadiusX = {rectElement.RadiusX},");
                sourceText.AppendLine($"            RadiusY = {rectElement.RadiusY},");
                if (!string.IsNullOrEmpty(rectElement.Transform))
                {
                    sourceText.AppendLine($"            Transform = {FormatMatrix(TransformParser.Parse(rectElement.Transform).Value)}");
                }
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is CircleElement circleElement)
            {
                sourceText.AppendLine(@"        new CircleDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, circleElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Center = new Avalonia.Point({circleElement.CenterX}, {circleElement.CenterY}),");
                sourceText.AppendLine($"            Radius = {circleElement.Radius}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is EllipseElement ellipseElement)
            {
                sourceText.AppendLine(@"        new EllipseDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, ellipseElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Center = new Avalonia.Point({ellipseElement.CenterX}, {ellipseElement.CenterY}),");
                sourceText.AppendLine($"            RadiusX = {ellipseElement.RadiusX},");
                sourceText.AppendLine($"            RadiusY = {ellipseElement.RadiusY}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is LineElement lineElement)
            {
                sourceText.AppendLine(@"        new LineDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, lineElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            StartPoint = new Avalonia.Point({lineElement.X1}, {lineElement.Y1}),");
                sourceText.AppendLine($"            EndPoint = new Avalonia.Point({lineElement.X2}, {lineElement.Y2}),");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is PolygonElement polygonElement)
            {
                var points = new List<string>();
                foreach (var point in polygonElement.Points)
                {
                    points.Add($"new Avalonia.Point({point.X}, {point.Y})");
                }
                sourceText.AppendLine(@"        new PolygonDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, polygonElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Points = [{string.Join(',', points)}]");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is PolylineElement polylineElement)
            {
                var points = new List<string>();
                foreach (var point in polylineElement.Points)
                {
                    points.Add($"new Avalonia.Point({point.X}, {point.Y})");
                }
                sourceText.AppendLine(@"        new PolylineDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, polylineElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Points = [{string.Join(',', points)}]");
                sourceText.AppendLine(@"        },");
            }
            if (graphicElement is PathElement pathElement)
            {
                sourceText.AppendLine(@"        new PathDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, pathElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Data = StreamGeometry.Parse(\"{pathElement.Data}\"),");
               
                if (!string.IsNullOrEmpty(pathElement.Transform))
                {
                    sourceText.AppendLine($"            Transform = {FormatMatrix(TransformParser.Parse(pathElement.Transform).Value)}");
                }
                sourceText.AppendLine(@"        },");
            }
        }
        sourceText.AppendLine(@"    ];");
        sourceText.AppendLine(@"");
        sourceText.AppendLine(@"    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;");
        sourceText.AppendLine("}");
        sourceText.AppendLine("");
        
        await output.WriteAsync(Encoding.UTF8.GetBytes(sourceText.ToString()));
    }

    private void GenerateCommonProperties(IconThemeType themeType, SvgGraphicElement graphicElement, int graphicElementCount, StringBuilder output)
    {
        output.AppendLine($"            Opacity = {graphicElement.Opacity},");
        if (themeType == IconThemeType.Filled || themeType == IconThemeType.Rounded || themeType == IconThemeType.Sharp)
        {
            output.AppendLine($"            FillBrush = IconBrushType.Fill,");
        }
        else if (themeType == IconThemeType.Outlined)
        {
            output.AppendLine($"            FillBrush = IconBrushType.Stroke,");
        }
        else if (themeType == IconThemeType.TwoTone)
        {
            if (graphicElementCount > 1)
            {
                var isSecondary = graphicElement.Opacity < 1.0;
                if (isSecondary)
                {
                    output.AppendLine($"            FillBrush = IconBrushType.Fill,");
                }
                else
                {
                    output.AppendLine($"            FillBrush = IconBrushType.Stroke,");
                }
            }
            else
            {
                output.AppendLine($"            FillBrush = IconBrushType.Stroke,");
            }
        }
    }

    private static Rect CalculateGeometryBounds(SvgParsedInfo svgParsedInfo)
    {
        var group = new GeometryGroup();
        foreach (var graphicElement in svgParsedInfo.GraphicElements)
        {
            if (graphicElement.FillColor == "none")
            {
                continue;
            }

            var geometry = BuildGeometry(graphicElement);
            if (geometry is null)
            {
                continue;
            }

            if ((graphicElement is RectElement or PathElement) &&
                !string.IsNullOrEmpty(graphicElement.Transform))
            {
                geometry.Transform = new MatrixTransform(TransformParser.Parse(graphicElement.Transform).Value);
            }

            group.Children.Add(geometry);
        }

        return group.Bounds;
    }

    private static Geometry? BuildGeometry(SvgGraphicElement graphicElement)
    {
        return graphicElement switch
        {
            RectElement rectElement => new RectangleGeometry(
                new Rect(rectElement.X, rectElement.Y, rectElement.Width, rectElement.Height),
                rectElement.RadiusX,
                rectElement.RadiusY),
            CircleElement circleElement => new EllipseGeometry
            {
                Center  = new Avalonia.Point(circleElement.CenterX, circleElement.CenterY),
                RadiusX = circleElement.Radius,
                RadiusY = circleElement.Radius
            },
            EllipseElement ellipseElement => new EllipseGeometry
            {
                Center  = new Avalonia.Point(ellipseElement.CenterX, ellipseElement.CenterY),
                RadiusX = ellipseElement.RadiusX,
                RadiusY = ellipseElement.RadiusY
            },
            LineElement lineElement => new LineGeometry
            {
                StartPoint = new Avalonia.Point(lineElement.X1, lineElement.Y1),
                EndPoint   = new Avalonia.Point(lineElement.X2, lineElement.Y2)
            },
            PolygonElement polygonElement => new PolylineGeometry
            {
                Points   = polygonElement.Points.Select(point => new Avalonia.Point(point.X, point.Y)).ToArray(),
                IsFilled = true
            },
            PolylineElement polylineElement => new PolylineGeometry
            {
                Points   = polylineElement.Points.Select(point => new Avalonia.Point(point.X, point.Y)).ToArray(),
                IsFilled = false
            },
            PathElement pathElement when !string.IsNullOrEmpty(pathElement.Data) => StreamGeometry.Parse(pathElement.Data),
            _ => null
        };
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

    private static string FormatRect(Rect rect)
    {
        return $"new Rect({FormatDouble(rect.X)}, {FormatDouble(rect.Y)}, {FormatDouble(rect.Width)}, {FormatDouble(rect.Height)})";
    }

    private static string FormatMatrix(Matrix matrix)
    {
        return $"new Matrix({FormatDouble(matrix.M11)}, {FormatDouble(matrix.M12)}, {FormatDouble(matrix.M21)}, {FormatDouble(matrix.M22)}, {FormatDouble(matrix.M31)}, {FormatDouble(matrix.M32)})";
    }

    private static string FormatDouble(double value)
    {
        if (Math.Abs(value) < 1e-12)
        {
            value = 0;
        }

        return value.ToString("G17", CultureInfo.InvariantCulture);
    }
    
    protected override async Task GenerateIconPackageClassesAsync()
    {
        await base.GenerateIconPackageClassesAsync();
        await GenerateIconRepositoryClassAsync();
    }

    private async Task GenerateIconRepositoryClassAsync()
    {
        var repoClsFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../gallery/MaterialGallery/Models/IconInfoRepository.g.cs"));
        if (File.Exists(repoClsFilePath))
        {
            File.Delete(repoClsFilePath);
        }
        await using var stream = new FileStream(repoClsFilePath, FileMode.Create, FileAccess.Write);
        var sourceText = new StringBuilder();
        sourceText.AppendLine("// This code is auto generated. Do not modify.");
        sourceText.AppendLine($"// Generated Date: {DateTime.Today.ToString("yyyy-MM-dd")}");
        sourceText.AppendLine("#nullable enable");
        sourceText.AppendLine("");
        sourceText.AppendLine("using Avalonia;");
        sourceText.AppendLine("using System;");
        sourceText.AppendLine("using Avalonia.Media;");
        sourceText.AppendLine("using AtomUI.Controls;");
        sourceText.AppendLine("using AtomUI.Media;");
        sourceText.AppendLine($"namespace MaterialGallery.Models;");
        
        sourceText.AppendLine("");
        
        sourceText.AppendLine($"public partial class IconInfoRepository");
        sourceText.AppendLine(@"{");
        sourceText.AppendLine(@"    public IconInfoRepository()");
        sourceText.AppendLine(@"    {");
        var categoryGroups = IconFiles
            .GroupBy(iconFileInfo => iconFileInfo.Category!)
            .OrderBy(group => group.Key)
            .ToList();
        var categories = categoryGroups.Select(group => group.Key);
        sourceText.AppendLine(@"        Categories = [");
        foreach (var category in categories)
        {
            sourceText.AppendLine($"            \"{category}\",");
        }
        sourceText.AppendLine(@"        ];");
        sourceText.AppendLine(@"    }");
        sourceText.AppendLine("");
        sourceText.AppendLine(@"    protected partial List<IconInfo> CreateIconInfos(string? category, IconThemeType iconTheme)");
        sourceText.AppendLine(@"    {");
        sourceText.AppendLine(@"        return category switch");
        sourceText.AppendLine(@"        {");
        foreach (var categoryGroup in categoryGroups)
        {
            var categoryName = categoryGroup.Key;
            sourceText.AppendLine($"            \"{categoryName}\" => Create{ToIdentifierPart(categoryName)}IconInfos(iconTheme),");
        }
        sourceText.AppendLine(@"            _ => []");
        sourceText.AppendLine(@"        };");
        sourceText.AppendLine(@"    }");

        foreach (var categoryGroup in categoryGroups)
        {
            var categoryName = categoryGroup.Key;
            var categoryIdentifier = ToIdentifierPart(categoryName);
            sourceText.AppendLine("");
            sourceText.AppendLine($"    private static List<IconInfo> Create{categoryIdentifier}IconInfos(IconThemeType iconTheme)");
            sourceText.AppendLine(@"    {");
            sourceText.AppendLine(@"        return iconTheme switch");
            sourceText.AppendLine(@"        {");
            foreach (var themeGroup in categoryGroup.GroupBy(iconFileInfo => iconFileInfo.ThemeType).OrderBy(group => group.Key))
            {
                sourceText.AppendLine($"            IconThemeType.{themeGroup.Key} => Create{categoryIdentifier}{themeGroup.Key}IconInfos(),");
            }
            sourceText.AppendLine(@"            _ => []");
            sourceText.AppendLine(@"        };");
            sourceText.AppendLine(@"    }");

            foreach (var themeGroup in categoryGroup.GroupBy(iconFileInfo => iconFileInfo.ThemeType).OrderBy(group => group.Key))
            {
                sourceText.AppendLine("");
                sourceText.AppendLine($"    private static List<IconInfo> Create{categoryIdentifier}{themeGroup.Key}IconInfos()");
                sourceText.AppendLine(@"    {");
                sourceText.AppendLine(@"        return [");
                foreach (var iconFileInfo in themeGroup.OrderBy(iconFileInfo => iconFileInfo.Name))
                {
                    AppendIconInfo(sourceText, iconFileInfo);
                }
                sourceText.AppendLine(@"        ];");
                sourceText.AppendLine(@"    }");
            }
        }
        sourceText.AppendLine(@"}");
        await stream.WriteAsync(Encoding.UTF8.GetBytes(sourceText.ToString()));
    }

    private static void AppendIconInfo(StringBuilder sourceText, IconFileInfo iconFileInfo)
    {
        var name = $"{iconFileInfo.Name}{iconFileInfo.ThemeType}";
        sourceText.AppendLine(@"            new IconInfo {");
        sourceText.AppendLine($"                Name = \"{name}\",");
        sourceText.AppendLine($"                Category = \"{iconFileInfo.Category}\",");
        sourceText.AppendLine($"                ThemeType = IconThemeType.{iconFileInfo.ThemeType},");
        sourceText.AppendLine($"                IconType = typeof(AtomUI.Icons.Material.{name}),");
        sourceText.AppendLine($"                Creator = () => new AtomUI.Icons.Material.{name}()");
        sourceText.AppendLine(@"            },");
    }

    private static string ToIdentifierPart(string value)
    {
        return Regex.Replace(value, @"[^a-zA-Z0-9_]", string.Empty);
    }
    
    public static string CapitalizeFirstLetter(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }
        return char.ToUpper(str[0]) + str.Substring(1);
    }

    private sealed class GeneratorApplication : Avalonia.Application;
}
