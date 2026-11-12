using UnityEditor;
using jp.unisakistudio.posingsystemeditor;

namespace jp.unisakistudio.coolposingeditor
{
    // This product's own translations (product name, its pose names and captions) are
    // generated into Editor/Localization/translations.json from Tools/Localization in
    // this repository. Shared text and the lookup itself belong to the Posing System.
    [InitializeOnLoad]
    internal static class CoolPosingLocalization
    {
        internal const string CatalogPath = "Packages/jp.unisakistudio.coolposing/Editor/Localization/translations.json";
        static CoolPosingLocalization() => PosingSystemLocalization.RegisterProductCatalog(CatalogPath);
    }
}
