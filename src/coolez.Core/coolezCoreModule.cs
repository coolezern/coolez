using Abp.Modules;
using Abp.Reflection.Extensions;
using coolez.Localization;

namespace coolez
{
    public class coolezCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            coolezLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = coolezConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(coolezCoreModule).GetAssembly());
        }
    }
}