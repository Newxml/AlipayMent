using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace JxStudioAPICenter
{
    [DependsOn(
        typeof(JxStudioAPICenterCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class JxStudioAPICenterApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JxStudioAPICenterApplicationModule).GetAssembly());
        }
    }
}