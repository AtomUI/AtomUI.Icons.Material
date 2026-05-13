using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using AtomUI.Controls;

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
        sourceText.AppendLine("using Avalonia;");
        sourceText.AppendLine("using System;");
        sourceText.AppendLine("using System.Collections.Generic;");
        sourceText.AppendLine("using Avalonia.Media;");
        sourceText.AppendLine("using AtomUI.Controls;");
        sourceText.AppendLine("using AtomUI.Media;");
        sourceText.AppendLine($"namespace {PackageNamespace};");
        sourceText.AppendLine("");
        var svgSource     = await File.ReadAllTextAsync(iconFileInfo.FilePath);
        var    svgParsedInfo = SvgParser.Parse(svgSource);
        var    viewBox       = svgParsedInfo.ViewBox;
        var    className     = $"{iconFileInfo.Name}{iconFileInfo.ThemeType}";
        
        sourceText.AppendLine($"public class {className} : Icon");
        sourceText.AppendLine(@"{");
        sourceText.AppendLine($"    public {className}()");
        sourceText.AppendLine(@"    {");
        sourceText.AppendLine($"        IconTheme = IconThemeType.{iconFileInfo.ThemeType};");
        sourceText.AppendLine($"        ViewBox = new Rect({viewBox.X}, {viewBox.Y}, {viewBox.Width}, {viewBox.Height});");
        sourceText.AppendLine(@"    }");
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
                    sourceText.AppendLine($"            Transform = TransformParser.Parse(\"{rectElement.Transform}\").Value");
                }
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is CircleElement circleElement)
            {
                sourceText.AppendLine(@"        new CircleDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, circleElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Center = new Point({circleElement.CenterX}, {circleElement.CenterY}),");
                sourceText.AppendLine($"            Radius = {circleElement.Radius}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is EllipseElement ellipseElement)
            {
                sourceText.AppendLine(@"        new EllipseDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, ellipseElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Center = new Point({ellipseElement.CenterX}, {ellipseElement.CenterY}),");
                sourceText.AppendLine($"            RadiusX = {ellipseElement.RadiusX},");
                sourceText.AppendLine($"            RadiusY = {ellipseElement.RadiusY}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is LineElement lineElement)
            {
                sourceText.AppendLine(@"        new LineDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonProperties(iconFileInfo.ThemeType, lineElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            StartPoint = new Point({lineElement.X1}, {lineElement.Y1}),");
                sourceText.AppendLine($"            EndPoint = new Point({lineElement.X2}, {lineElement.Y2}),");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is PolygonElement polygonElement)
            {
                var points = new List<string>();
                foreach (var point in polygonElement.Points)
                {
                    points.Add($"new Point({point.X}, {point.Y})");
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
                    points.Add($"new Point({point.X}, {point.Y})");
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
                    sourceText.AppendLine($"            Transform = TransformParser.Parse(\"{pathElement.Transform}\").Value");
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
}
