using Abp.AspNetCore.Mvc.Views;

namespace coolez.Web.Views
{
    public abstract class coolezRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected coolezRazorPage()
        {
            LocalizationSourceName = coolezConsts.LocalizationSourceName;
        }
    }
}
