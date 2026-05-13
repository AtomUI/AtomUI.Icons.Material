using AtomUI.Theme;
using AtomUI.Theme.Language;

namespace MaterialGallery.Localization
{
    public enum WorkspaceWindowLangResourceKind
    {
        MenuItemCompactMode,
        MenuItemDarkMode,
        MenuItemEnableFullScreen,
        MenuItemEnableMaximize,
        MenuItemEnableMinimize,
        MenuItemEnableMotion,
        MenuItemEnableMove,
        MenuItemEnablePin,
        MenuItemEnableResize,
        MenuItemEnableWaveSpirit,
        MenuItemLanguage,
        MenuItemSettings,
        MenuItemTheme,
        MenuItemWindowOptions
    }

    public class WorkspaceWindowLangResourceExtension : LanguageResourceExtension<WorkspaceWindowLangResourceKind>
    {
        public WorkspaceWindowLangResourceExtension()
        {
        }

        public WorkspaceWindowLangResourceExtension(WorkspaceWindowLangResourceKind kind) : base(kind)
        {
        }
    }
}