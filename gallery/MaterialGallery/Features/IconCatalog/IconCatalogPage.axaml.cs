using AtomUI.Desktop.Controls;
using AtomUI.Toolkits.GalleryBase.Controls;
using AtomUI.Toolkits.GalleryBase.Localization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;
using MaterialGallery.Controls;
using MaterialGallery.Localization;
using MaterialIconInfoItem = MaterialGallery.Controls.IconInfoItem;

namespace MaterialGallery.Features.IconCatalog;

public partial class IconCatalogPage : GalleryReactiveUserControl<IconCatalogPageViewModel>
{
    private readonly Func<string, CancellationToken, Task>? _clipboardWriter;
    private readonly Action<string>? _successFeedback;
    private readonly bool _useTopLevelClipboard;
    private CancellationTokenSource? _copyCancellation;
    private WindowMessageManager? _messageManager;
    private int _copyRequestSequence;
    private bool _isAttached;

    public IconCatalogPage()
        : this(null, null, true)
    {
    }

    internal IconCatalogPage(
        Func<string, CancellationToken, Task>? clipboardWriter,
        Action<string>? successFeedback)
        : this(clipboardWriter, successFeedback, false)
    {
    }

    private IconCatalogPage(
        Func<string, CancellationToken, Task>? clipboardWriter,
        Action<string>? successFeedback,
        bool useTopLevelClipboard)
    {
        _clipboardWriter      = clipboardWriter;
        _successFeedback      = successFeedback;
        _useTopLevelClipboard = useTopLevelClipboard;
        InitializeComponent();
        AddHandler(MaterialIconInfoItem.ClickedEvent, HandleIconClicked);
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        _isAttached = true;
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        _isAttached = false;
        _copyRequestSequence++;
        _copyCancellation?.Cancel();
        _copyCancellation?.Dispose();
        _copyCancellation = null;
        _messageManager?.Dispose();
        _messageManager = null;
        base.OnDetachedFromVisualTree(e);
    }

    private async void HandleIconClicked(object? sender, RoutedEventArgs e)
    {
        if (e.Source is not MaterialIconInfoItem { IconName: { } iconName } ||
            string.IsNullOrWhiteSpace(iconName))
        {
            return;
        }

        e.Handled = true;
        await RequestCopyAsync(iconName);
    }

    internal async Task<bool> RequestCopyAsync(string iconName)
    {
        if (string.IsNullOrWhiteSpace(iconName) || !_isAttached)
        {
            return false;
        }

        var copyRequest = ++_copyRequestSequence;
        _copyCancellation?.Cancel();
        _copyCancellation?.Dispose();
        _copyCancellation = new CancellationTokenSource();
        var cancellationToken = _copyCancellation.Token;

        var writer = _clipboardWriter;
        if (_useTopLevelClipboard)
        {
            var clipboard = TopLevel.GetTopLevel(this)?.Clipboard;
            if (clipboard is not null)
            {
                writer = async (text, token) =>
                {
                    token.ThrowIfCancellationRequested();
                    await clipboard.SetTextAsync(text);
                    token.ThrowIfCancellationRequested();
                };
            }
        }

        if (writer is null)
        {
            return false;
        }

        try
        {
            await writer(iconName, cancellationToken);
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            return false;
        }
        catch
        {
            return false;
        }

        if (!_isAttached || cancellationToken.IsCancellationRequested || copyRequest != _copyRequestSequence)
        {
            return false;
        }

        var format = new GalleryLocalizedText<IconCatalogPageLangResourceKind>(
                IconCatalogPageLangResourceKind.IconCopied,
                "<{0} /> copied 🎉")
            .ToString();
        var message = string.Format(format, iconName);
        if (_successFeedback is not null)
        {
            _successFeedback(message);
        }
        else
        {
            GetMessageManager()?.Show(new Message(
                message,
                MessageType.Success,
                expiration: TimeSpan.FromSeconds(2)));
        }

        return true;
    }

    private WindowMessageManager? GetMessageManager()
    {
        if (_messageManager is not null)
        {
            return _messageManager;
        }

        var topLevel = TopLevel.GetTopLevel(this);
        if (topLevel is null)
        {
            return null;
        }

        return _messageManager = new WindowMessageManager(topLevel)
        {
            MaxItems = 1
        };
    }
}
