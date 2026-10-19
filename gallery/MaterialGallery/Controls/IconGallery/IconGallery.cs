using System.Reactive.Disposables;
using AtomUI.Controls;
using AtomUI.Data;
using AtomUI.Desktop.Controls;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using MaterialGallery.Controls.Themes;
using MaterialGallery.Models;
using ScrollViewer = AtomUI.Desktop.Controls.ScrollViewer;

namespace MaterialGallery.Controls;

public class IconGallery : TemplatedControl, IMotionAwareControl
{
    private const double LoadMoreScrollThreshold = 240;

    public static readonly StyledProperty<string?> CategoryProperty = 
        AvaloniaProperty.Register<IconGallery, string?>(nameof (Category));
    
    public static readonly StyledProperty<IconThemeType> IconThemeProperty = 
        AvaloniaProperty.Register<IconGallery, IconThemeType>(nameof (IconTheme));
    
    public static readonly StyledProperty<IEnumerable<IconInfo>?> IconInfosProperty = 
        AvaloniaProperty.Register<IconGallery, IEnumerable<IconInfo>?>(nameof (IconInfos));
    
    public static readonly StyledProperty<IconInfoRepository?> IconInfoRepositoryProperty = 
        AvaloniaProperty.Register<IconGallery, IconInfoRepository?>(nameof (IconInfoRepository));

    public static readonly StyledProperty<bool> HasMatchesProperty =
        AvaloniaProperty.Register<IconGallery, bool>(nameof(HasMatches), true);

    public static readonly StyledProperty<string?> SearchPlaceholderProperty =
        AvaloniaProperty.Register<IconGallery, string?>(nameof(SearchPlaceholder));

    public static readonly StyledProperty<string?> EmptyTitleProperty =
        AvaloniaProperty.Register<IconGallery, string?>(nameof(EmptyTitle));

    public static readonly StyledProperty<string?> EmptyDescriptionProperty =
        AvaloniaProperty.Register<IconGallery, string?>(nameof(EmptyDescription));
    
    public static readonly StyledProperty<bool> IsMotionEnabledProperty =
        MotionAwareControlProperty.IsMotionEnabledProperty.AddOwner<IconGallery>();
    
    public string? Category
    {
        get => GetValue(CategoryProperty);
        set => SetValue(CategoryProperty, value);
    }
    
    public IconThemeType IconTheme
    {
        get => GetValue(IconThemeProperty);
        set => SetValue(IconThemeProperty, value);
    }

    public IEnumerable<IconInfo>? IconInfos
    {
        get => GetValue(IconInfosProperty);
        set => SetValue(IconInfosProperty, value);
    }
    
    public IconInfoRepository? IconInfoRepository
    {
        get => GetValue(IconInfoRepositoryProperty);
        set => SetValue(IconInfoRepositoryProperty, value);
    }

    public bool HasMatches
    {
        get => GetValue(HasMatchesProperty);
        set => SetValue(HasMatchesProperty, value);
    }

    public string? SearchPlaceholder
    {
        get => GetValue(SearchPlaceholderProperty);
        set => SetValue(SearchPlaceholderProperty, value);
    }

    public string? EmptyTitle
    {
        get => GetValue(EmptyTitleProperty);
        set => SetValue(EmptyTitleProperty, value);
    }

    public string? EmptyDescription
    {
        get => GetValue(EmptyDescriptionProperty);
        set => SetValue(EmptyDescriptionProperty, value);
    }
    
    public bool IsMotionEnabled
    {
        get => GetValue(IsMotionEnabledProperty);
        set => SetValue(IsMotionEnabledProperty, value);
    }
    
    private CompositeDisposable? _disposables;
    private ScrollViewer? _scrollViewer;
    private SearchEdit? _searchEdit;
    private bool _templateHandlersAttached;
    
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == IconInfoRepositoryProperty)
        {
            HandleCondChanged();
        }
        else if (change.Property == IconInfosProperty)
        {
            if (_scrollViewer != null)
            {
                _scrollViewer.Offset = new Vector(0, 0);
            }
        }
    }

    private void HandleCondChanged()
    {
        _disposables?.Dispose();
        _disposables = null;
        if (IconInfoRepository != null)
        {
            _disposables = new CompositeDisposable();
            _disposables.Add(BindUtils.RelayBind(this, CategoryProperty, IconInfoRepository, IconInfoRepository.CategoryProperty));
            _disposables.Add(BindUtils.RelayBind(this, IconThemeProperty, IconInfoRepository, IconInfoRepository.IconThemeProperty));
            _disposables.Add(BindUtils.RelayBind(IconInfoRepository, IconInfoRepository.ActivatedIconInfosProperty, this, IconInfosProperty));
            _disposables.Add(BindUtils.RelayBind(IconInfoRepository, IconInfoRepository.HasMatchesProperty, this, HasMatchesProperty));
            IconInfoRepository.RefreshIconInfos();
        }
        else
        {
            SetCurrentValue(HasMatchesProperty, false);
        }
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        DetachTemplateHandlers();
        base.OnApplyTemplate(e);
        _scrollViewer = e.NameScope.Find<ScrollViewer>(IconGalleryThemeConstants.ScrollViewerPart);
        _searchEdit = e.NameScope.Find<SearchEdit>(IconGalleryThemeConstants.SearchInputPart);
        AttachTemplateHandlers();
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        if (_disposables is null)
        {
            HandleCondChanged();
        }

        AttachTemplateHandlers();
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        DetachTemplateHandlers();
        _disposables?.Dispose();
        _disposables = null;
        base.OnDetachedFromVisualTree(e);
    }

    private void AttachTemplateHandlers()
    {
        if (_templateHandlersAttached)
        {
            return;
        }

        if (_scrollViewer != null)
        {
            _scrollViewer.ScrollChanged += HandleScrollChanged;
        }
        if (_searchEdit != null)
        {
            _searchEdit.SearchRequested += HandleSearchRequested;
        }

        _templateHandlersAttached = _scrollViewer is not null || _searchEdit is not null;
    }

    private void DetachTemplateHandlers()
    {
        if (_scrollViewer != null)
        {
            _scrollViewer.ScrollChanged -= HandleScrollChanged;
        }

        if (_searchEdit != null)
        {
            _searchEdit.SearchRequested -= HandleSearchRequested;
        }

        _templateHandlersAttached = false;
    }

    private void HandleScrollChanged(object? sender, ScrollChangedEventArgs e)
    {
        if (_scrollViewer == null || IconInfoRepository?.HasMoreIconInfos != true)
        {
            return;
        }

        var remainingHeight = _scrollViewer.Extent.Height - _scrollViewer.Viewport.Height - _scrollViewer.Offset.Y;
        if (remainingHeight <= LoadMoreScrollThreshold)
        {
            IconInfoRepository.LoadMoreIconInfos();
        }
    }

    private void HandleSearchRequested(object? sender, SearchRequestedEventArgs e)
    {
        if (IconInfoRepository != null)
        {
            IconInfoRepository.Filter = e.Query.Trim();
        }
    }
}
