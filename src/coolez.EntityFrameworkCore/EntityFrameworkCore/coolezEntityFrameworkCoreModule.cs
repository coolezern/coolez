using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace coolez.EntityFrameworkCore
{
    [DependsOn(
        typeof(coolezCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class coolezEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(coolezEntityFrameworkCoreModule).GetAssembly());
        }
    }
}