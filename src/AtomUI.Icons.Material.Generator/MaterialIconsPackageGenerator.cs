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

            var name = categoryName + CapitalizeFirstLetter(iconBaseName) + themeType;
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
        sourceText.AppendLine($"// Generated Date: {DateTime.Today.ToString("yyyy-MM-dd")}");
        sourceText.AppendLine("");
        sourceText.AppendLine("using Avalonia;");
        sourceText.AppendLine("using System;");
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
        for (var i = 0; i < svgParsedInfo.GraphicElements.Count; i++)
        {
            var graphicElement  = svgParsedInfo.GraphicElements[i];
            if (graphicElement is RectElement rectElement)
            {
                sourceText.AppendLine(@"        new RectDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                sourceText.AppendLine($"            Opacity = {rectElement.Opacity},");
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
                sourceText.AppendLine($"            Opacity = {circleElement.Opacity},");
                sourceText.AppendLine($"            Center = new Point({circleElement.CenterX}, {circleElement.CenterY}),");
                sourceText.AppendLine($"            Radius = {circleElement.Radius}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is EllipseElement ellipseElement)
            {
                sourceText.AppendLine(@"        new EllipseDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                sourceText.AppendLine($"            Opacity = {ellipseElement.Opacity},");
                sourceText.AppendLine($"            Center = new Point({ellipseElement.CenterX}, {ellipseElement.CenterY}),");
                sourceText.AppendLine($"            RadiusX = {ellipseElement.RadiusX},");
                sourceText.AppendLine($"            RadiusY = {ellipseElement.RadiusY}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is LineElement lineElement)
            {
                sourceText.AppendLine(@"        new LineDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                sourceText.AppendLine($"            Opacity = {lineElement.Opacity},");
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
                sourceText.AppendLine($"            Opacity = {polygonElement.Opacity},");
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
                sourceText.AppendLine($"            Opacity = {polylineElement.Opacity},");
                sourceText.AppendLine($"            Points = [{string.Join(',', points)}]");
                sourceText.AppendLine(@"        },");
            }
            if (graphicElement is PathElement pathElement)
            {
                sourceText.AppendLine(@"        new PathDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                sourceText.AppendLine($"            Opacity = {pathElement.Opacity},");
                sourceText.AppendLine($"            Data = StreamGeometry.Parse(\"{pathElement.Data}\"),");
                if (iconFileInfo.ThemeType == IconThemeType.Filled)
                {
                    sourceText.AppendLine($"            FillBrush = IconBrushType.Fill,");
                }
                else if (iconFileInfo.ThemeType == IconThemeType.Outlined)
                {
                    sourceText.AppendLine($"            FillBrush = IconBrushType.Stroke,");
                }
                else if (iconFileInfo.ThemeType == IconThemeType.TwoTone)
                {
                    var isPrimary = pathElement.Opacity < 1.0;
                    if (isPrimary)
                    {
                        sourceText.AppendLine($"            FillBrush = IconBrushType.Stroke,");
                    }
                    else
                    {
                        sourceText.AppendLine($"            FillBrush = IconBrushType.Fill,");
                    }
                }
               
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
    
    public static string CapitalizeFirstLetter(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }
        return char.ToUpper(str[0]) + str.Substring(1);
    }
}