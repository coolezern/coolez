using Abp.AspNetCore.Mvc.Controllers;

namespace coolez.Web.Controllers
{
    public abstract class coolezControllerBase: AbpController
    {
        protected coolezControllerBase()
        {
            LocalizationSourceName = coolezConsts.LocalizationSourceName;
        }
    }
}