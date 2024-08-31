using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace coolez
{
    [DependsOn(
        typeof(coolezCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class coolezApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(coolezApplicationModule).GetAssembly());
        }
    }
}