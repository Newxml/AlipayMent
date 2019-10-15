using Abp.Application.Services;

namespace JxStudioAPICenter
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class JxStudioAPICenterAppServiceBase : ApplicationService
    {
        protected JxStudioAPICenterAppServiceBase()
        {
            LocalizationSourceName = JxStudioAPICenterConsts.LocalizationSourceName;
        }
    }
}