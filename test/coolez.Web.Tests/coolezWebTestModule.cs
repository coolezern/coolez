using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using coolez.Web.Startup;
namespace coolez.Web.Tests
{
    [DependsOn(
        typeof(coolezWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class coolezWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(coolezWebTestModule).GetAssembly());
        }
    }
}