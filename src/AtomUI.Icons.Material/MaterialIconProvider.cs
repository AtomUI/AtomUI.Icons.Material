using System.Diagnostics;
using System.Reflection;
using AtomUI.Controls;

namespace AtomUI.Icons.Material;

public class MaterialIconProvider : IconProvider<MaterialIconKind>
{
    public MaterialIconProvider()
    {
    }
    
    public MaterialIconProvider(MaterialIconKind kind)
        : base(kind)
    {
    }
    
    protected override Icon GetIcon(MaterialIconKind kind)
    {
        try
        {
            var fullTypeName = $"AtomUI.Icons.Material.{kind.ToString()}";
            var type = Type.GetType(fullTypeName) 
                       ?? Assembly.GetExecutingAssembly().GetType(fullTypeName);
            
            if (type == null)
            {
                throw new InvalidOperationException($"{fullTypeName} not exist");
            }
            
            var icon = (Icon?)Activator.CreateInstance(type);
            Debug.Assert(icon != null);
            return icon;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"create icon {kind.ToString()} failed", ex);
        }
    }
}