using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using coolez.Configuration;
using coolez.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace coolez.Web.Startup
{
    [DependsOn(
        typeof(coolezApplicationModule), 
        typeof(coolezEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class coolezWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public coolezWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(coolezConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<coolezNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(coolezApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(coolezWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(coolezWebModule).Assembly);
        }
    }
}
