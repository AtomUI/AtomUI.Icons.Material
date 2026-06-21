using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AtomUI.Theme;

namespace AtomUI.Theme
{
    internal class ControlTokenTypePool
    {
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(MaterialGallery.Controls.IconGalleryToken))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties, typeof(MaterialGallery.Controls.NavigationToken))]
        internal static IList<ControlTokenRegistration> GetTokenTypes()
        {
            List<ControlTokenRegistration> tokenTypes = new List<ControlTokenRegistration>(2);
            tokenTypes.Add(new ControlTokenRegistration(typeof(MaterialGallery.Controls.IconGalleryToken)));
            tokenTypes.Add(new ControlTokenRegistration(typeof(MaterialGallery.Controls.NavigationToken)));
            return tokenTypes;
        }
    }
}