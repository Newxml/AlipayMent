 using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JxStudioAPICenter.Configuration;
using JxStudioAPICenter.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace JxStudioAPICenter.Web.Startup
{
    [DependsOn(
        typeof(JxStudioAPICenterApplicationModule), 
        typeof(JxStudioAPICenterEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class JxStudioAPICenterWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public JxStudioAPICenterWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(JxStudioAPICenterConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<JxStudioAPICenterNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(JxStudioAPICenterApplicationModule).GetAssembly(),
                    useConventionalHttpVerbs: false
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JxStudioAPICenterWebModule).GetAssembly());
        }
    }
}