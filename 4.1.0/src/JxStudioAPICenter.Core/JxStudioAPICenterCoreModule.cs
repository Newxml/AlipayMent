using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Essensoft.AspNetCore.Payment.Alipay;
using JxStudioAPICenter.Alipay;
using JxStudioAPICenter.Localization;

namespace JxStudioAPICenter
{
    public class JxStudioAPICenterCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            JxStudioAPICenterLocalizationConfigurer.Configure(Configuration.Localization);
            IocManager.Register<IAlipayManager, AlipayManager>();
            IocManager.Register<IAlipayClient, AlipayClient>();
            IocManager.Register<IAlipayNotifyClient, AlipayNotifyClient>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JxStudioAPICenterCoreModule).GetAssembly());
        }
    }
}