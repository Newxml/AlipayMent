using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace JxStudioAPICenter.EntityFrameworkCore
{
    [DependsOn(
        typeof(JxStudioAPICenterCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class JxStudioAPICenterEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JxStudioAPICenterEntityFrameworkCoreModule).GetAssembly());
        }
    }
}