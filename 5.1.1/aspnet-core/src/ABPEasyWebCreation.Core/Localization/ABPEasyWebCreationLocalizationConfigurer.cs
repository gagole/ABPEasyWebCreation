using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ABPEasyWebCreation.Localization
{
    public static class ABPEasyWebCreationLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABPEasyWebCreationConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABPEasyWebCreationLocalizationConfigurer).GetAssembly(),
                        "ABPEasyWebCreation.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
