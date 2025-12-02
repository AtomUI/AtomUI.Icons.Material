using AtomUI.Animations;
using AtomUI.Controls;
using AtomUI.Theme;
using AtomUI.Utils;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace MaterialGallery.Controls;

public class IconInfoItem : TemplatedControl, IControlSharedTokenResourcesHost, IMotionAwareControl
{
    public static readonly StyledProperty<string> IconNameProperty = 
        AvaloniaProperty.Register<IconInfoItem, string>(nameof(IconName));
    
    public static readonly StyledProperty<Icon> IconProperty = 
        AvaloniaProperty.Register<IconInfoItem, Icon>(nameof(Icon));
    
    public static readonly StyledProperty<bool> IsMotionEnabledProperty =
        MotionAwareControlProperty.IsMotionEnabledProperty.AddOwner<IconInfoItem>();

    public string IconName
    {
        get => GetValue(IconNameProperty);
        set => SetValue(IconNameProperty, value);
    }
    
    public Icon Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
    
    public bool IsMotionEnabled
    {
        get => GetValue(IsMotionEnabledProperty);
        set => SetValue(IsMotionEnabledProperty, value);
    }

    public static readonly RoutedEvent<RoutedEventArgs> ClickedEvent =
        RoutedEvent.Register<IconInfoItem, RoutedEventArgs>(nameof(Clicked), RoutingStrategies.Bubble);
    
    public event EventHandler<RoutedEventArgs> Clicked
    {
        add => AddHandler(ClickedEvent, value);
        remove => RemoveHandler(ClickedEvent, value);
    }
    
    #region 内部属性定义

    Control IControlSharedTokenResourcesHost.HostControl => this;
    string IControlSharedTokenResourcesHost.TokenId => IconGalleryToken.ID;
    Control IMotionAwareControl.PropertyBindTarget => this;
    #endregion
    
    public IconInfoItem()
    {
        this.RegisterResources();
    }
    
    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        ConfigureTransitions(false);
    }

    protected override void OnUnloaded(RoutedEventArgs e)
    {
        base.OnUnloaded(e);
        Transitions = null;
    }
    
    private void ConfigureTransitions(bool force)
    {
        if (IsMotionEnabled)
        {
            if (force || Transitions == null)
            {
                Transitions = [
                    TransitionUtils.CreateTransition<SolidColorBrushTransition>(BackgroundProperty)
                ];
            }
        }
        else
        {
            Transitions = null;
        }
    }

    protected override void OnPointerReleased(PointerReleasedEventArgs e)
    {
        base.OnPointerReleased(e);
        RaiseEvent(new RoutedEventArgs(ClickedEvent, this));
    }
}
