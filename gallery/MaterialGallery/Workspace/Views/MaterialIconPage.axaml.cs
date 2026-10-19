using AtomUI.Toolkits.GalleryBase.Controls;
using Avalonia.Markup.Xaml;
using MaterialGallery.Workspace.ViewModels;

namespace MaterialGallery.Workspace.Views;

public partial class MaterialIconPage : GalleryReactiveUserControl<MaterialIconPageViewModel>
{
    public MaterialIconPage()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
