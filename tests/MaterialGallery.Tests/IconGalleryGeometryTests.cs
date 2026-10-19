using AtomUI.Desktop.Controls;
using AtomUI.Toolkits.GalleryBase.Shell;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Headless;
using Avalonia.Input;
using Avalonia.Threading;
using Avalonia.VisualTree;
using MaterialGallery.Controls;
using MaterialGallery.Features.IconCatalog;
using MaterialGallery.Workspace.ViewModels;
using MaterialGallery.Workspace.Views;
using ReactiveUI;
using ScrollViewer = AtomUI.Desktop.Controls.ScrollViewer;

namespace MaterialGallery.Tests;

public class IconGalleryGeometryTests
{
    [Theory]
    [InlineData(1300, 900)]
    [InlineData(1040, 720)]
    public void Shell_preserves_sidebar_scrolling_incremental_loading_and_full_icon_hit_targets(
        double width,
        double height)
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();
        var navigation = new CaseNavigation { ViewModel = workspace.CaseNavigation };
        using var shell = new GalleryShellView(
            MaterialGalleryModule.GetConfiguration(),
            navigation,
            workspace.Router);
        var window = new Avalonia.Controls.Window { Width = width, Height = height, Content = shell };

        try
        {
            window.Show();
            Dispatcher.UIThread.RunJobs();
            workspace.CaseNavigation.NavigateToCommand.Execute("Action").Subscribe();
            Dispatcher.UIThread.RunJobs();
            workspace.Router.NavigationStack.Count.ShouldBe(1);
            workspace.Router.NavigationStack[0].ShouldBeOfType<IconCatalogPageViewModel>();

            var sidebar = shell.GetVisualDescendants()
                           .OfType<Border>()
                           .Single(control => control.Name == "WorkspaceSidebar");
            sidebar.Bounds.Width.ShouldBeGreaterThan(0);
            sidebar.Bounds.Height.ShouldBeGreaterThan(0);
            shell.ContentHost.Bounds.Width.ShouldBeGreaterThan(0);
            shell.ContentHost.Bounds.Height.ShouldBeGreaterThan(0);

            var gallery = shell.GetVisualDescendants().OfType<IconGallery>().Single();
            gallery.ApplyTemplate();
            Dispatcher.UIThread.RunJobs();
            using var renderedFrame = window.CaptureRenderedFrame();
            var scrollViewer = gallery.GetVisualDescendants()
                                  .OfType<ScrollViewer>()
                                  .Single(viewer =>
                                      viewer.Name == "PART_ScrollViewer" &&
                                      ReferenceEquals(viewer.TemplatedParent, gallery));
            scrollViewer.Viewport.Width.ShouldBeGreaterThan(0);
            scrollViewer.Viewport.Height.ShouldBeGreaterThan(0);
            scrollViewer.Extent.Height.ShouldBeGreaterThan(scrollViewer.Viewport.Height);
            scrollViewer.GetVisualDescendants()
                    .OfType<Avalonia.Controls.Primitives.ScrollBar>()
                    .Any(bar => bar.Orientation == Avalonia.Layout.Orientation.Vertical && bar.IsVisible)
                    .ShouldBeTrue();

            var item = gallery.GetVisualDescendants().OfType<IconInfoItem>().First();
            item.Bounds.Width.ShouldBeGreaterThan(4);
            item.Bounds.Height.ShouldBeGreaterThan(4);
            foreach (var localX in new[] { 2d, item.Bounds.Width / 2, item.Bounds.Width - 2 })
            {
                var point = item.TranslatePoint(new Point(localX, item.Bounds.Height / 2), window)
                            .ShouldNotBeNull();
                var hit = (window.InputHitTest(point) as Visual).ShouldNotBeNull();
                (ReferenceEquals(hit, item) || hit.GetVisualAncestors().Contains(item)).ShouldBeTrue(
                    $"Expected the icon item to own hit point {point}, but hit {Describe(hit, window)}. " +
                    $"Item={Describe(item, window)}. ItemVisuals={DescribeDescendants(item, window)}. " +
                    $"Scroll={Describe(scrollViewer, window)}.");
            }

            var repository = gallery.IconInfoRepository.ShouldNotBeNull();
            var countBeforeScroll = repository.ActivatedIconInfos!.Count();
            scrollViewer.Offset = new Vector(
            scrollViewer.Offset.X,
            scrollViewer.Extent.Height - scrollViewer.Viewport.Height);
            Dispatcher.UIThread.RunJobs();
            repository.ActivatedIconInfos!.Count().ShouldBeGreaterThan(countBeforeScroll);
        }
        finally
        {
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    private static string Describe(Visual visual, Visual root)
    {
        var origin = visual.TranslatePoint(default, root);
        var chain = visual.GetVisualAncestors()
                          .Take(15)
                          .Select(ancestor =>
                          {
                              var ancestorOrigin = ancestor.TranslatePoint(default, root);
                              return $"{ancestor.GetType().Name}#{(ancestor as Control)?.Name ?? "-"}" +
                                     $"@{ancestorOrigin}/{ancestor.Bounds}";
                          });
        return $"{visual.GetType().Name}#{(visual as Control)?.Name ?? "-"} " +
               $"origin={origin} bounds={visual.Bounds} ancestors=[{string.Join(" > ", chain)}]";
    }

    private static string DescribeDescendants(Visual visual, Visual root)
    {
        return string.Join(
            " | ",
            visual.GetVisualDescendants()
                  .Take(10)
                  .Select(descendant =>
                  {
                      var origin = descendant.TranslatePoint(default, root);
                      var background = descendant is Border border ? $" bg={border.Background}" : string.Empty;
                      return $"{descendant.GetType().Name}#{(descendant as Control)?.Name ?? "-"}" +
                             $"@{origin}/{descendant.Bounds}{background}";
                  }));
    }
}
