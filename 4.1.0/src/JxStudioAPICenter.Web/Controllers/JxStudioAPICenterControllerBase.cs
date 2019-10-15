using Abp.AspNetCore.Mvc.Controllers;

namespace JxStudioAPICenter.Web.Controllers
{
    public abstract class JxStudioAPICenterControllerBase: AbpController
    {
        protected JxStudioAPICenterControllerBase()
        {
            LocalizationSourceName = JxStudioAPICenterConsts.LocalizationSourceName;
        }
    }
}