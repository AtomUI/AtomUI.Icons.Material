using System.Reflection;
using AtomUI.Controls;

namespace AtomUI.Icons.Material;

public class MaterialIconProvider : IconProvider<MaterialIconKind>
{
    public MaterialIconProvider()
    {
    }

    public MaterialIconProvider(MaterialIconKind kind) : base(kind)
    {
    }

    protected override Type GetTypeForKind(MaterialIconKind kind)
    {
        var typeName = $"AtomUI.Icons.IconPark.{kind.ToString()}";

        var type = Type.GetType(typeName)
                   ?? Assembly.GetExecutingAssembly().GetType(typeName);
        if (type == null)
        {
            throw new InvalidOperationException($"Type {typeName} does not exist");
        }

        return type;
    }
}