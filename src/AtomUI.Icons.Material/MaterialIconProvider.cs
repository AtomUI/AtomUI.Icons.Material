using System.Diagnostics.CodeAnalysis;
using AtomUI.Controls;

namespace AtomUI.Icons.Material;

public partial class MaterialIconProvider : IconProvider<MaterialIconKind>
{
    public MaterialIconProvider()
    {
    }

    public MaterialIconProvider(MaterialIconKind kind) : base(kind)
    {
    }

    protected override Icon GetIcon(MaterialIconKind kind)
    {
        try
        {
            return CreateIcon(kind);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Create icon {kind} failed", ex);
        }
    }

    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    protected override Type GetTypeForKind(MaterialIconKind kind)
    {
        return GetIconType(kind);
    }
}
