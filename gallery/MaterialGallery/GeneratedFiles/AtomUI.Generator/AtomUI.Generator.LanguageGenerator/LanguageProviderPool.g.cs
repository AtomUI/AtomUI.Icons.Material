using System.Collections.Generic;
using AtomUI.Theme.Language;
using Avalonia.Controls;

namespace AtomUI.Theme.Language
{
    internal sealed class WorkspaceWindowEnUSLanguageProvider : LanguageProvider
    {
        public WorkspaceWindowEnUSLanguageProvider()
            : base(LanguageCode.en_US, "WorkspaceWindow")
        {
        }

        protected override System.Type GetResourceKindType()
        {
            return typeof(global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind);
        }

        public override void BuildResourceDictionary(IResourceDictionary dictionary)
        {
            var resourceKindType = GetResourceKindType();
            try
            {
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemCompactMode] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemCompactMode;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemDarkMode] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemDarkMode;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableFullScreen] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableFullScreen;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMaximize] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableMaximize;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMinimize] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableMinimize;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMotion] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableMotion;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMove] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableMove;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnablePin] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnablePin;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableResize] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableResize;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableWaveSpirit] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableWaveSpirit;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemLanguage] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemLanguage;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemSettings] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemSettings;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemTheme] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemTheme;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemWindowOptions] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemWindowOptions;
            }
            catch (System.Exception)
            {
                LogBuildResourceDictionaryError(resourceKindType);
                throw;
            }
        }
    }

    internal sealed class WorkspaceWindowZhCNLanguageProvider : LanguageProvider
    {
        public WorkspaceWindowZhCNLanguageProvider()
            : base(LanguageCode.zh_CN, "WorkspaceWindow")
        {
        }

        protected override System.Type GetResourceKindType()
        {
            return typeof(global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind);
        }

        public override void BuildResourceDictionary(IResourceDictionary dictionary)
        {
            var resourceKindType = GetResourceKindType();
            try
            {
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemCompactMode] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemCompactMode;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemDarkMode] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemDarkMode;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableFullScreen] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableFullScreen;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMaximize] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableMaximize;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMinimize] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableMinimize;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMotion] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableMotion;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMove] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableMove;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnablePin] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnablePin;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableResize] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableResize;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableWaveSpirit] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableWaveSpirit;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemLanguage] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemLanguage;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemSettings] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemSettings;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemTheme] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemTheme;
                dictionary[global::MaterialGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemWindowOptions] = global::MaterialGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemWindowOptions;
            }
            catch (System.Exception)
            {
                LogBuildResourceDictionaryError(resourceKindType);
                throw;
            }
        }
    }

    internal class LanguageProviderPool
    {
        internal static IList<LanguageProvider> GetLanguageProviders()
        {
            List<LanguageProvider> languageProviders = new List<LanguageProvider>(2);
            languageProviders.Add(new WorkspaceWindowEnUSLanguageProvider());
            languageProviders.Add(new WorkspaceWindowZhCNLanguageProvider());
            return languageProviders;
        }
    }
}
