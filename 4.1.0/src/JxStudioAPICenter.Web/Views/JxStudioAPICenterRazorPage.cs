using Abp.AspNetCore.Mvc.Views;

namespace JxStudioAPICenter.Web.Views
{
    public abstract class JxStudioAPICenterRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected JxStudioAPICenterRazorPage()
        {
            LocalizationSourceName = JxStudioAPICenterConsts.LocalizationSourceName;
        }
    }
}
