using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HomeAssignment.Localization
{
    public static class HomeAssignmentLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HomeAssignmentConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HomeAssignmentLocalizationConfigurer).GetAssembly(),
                        "HomeAssignment.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
