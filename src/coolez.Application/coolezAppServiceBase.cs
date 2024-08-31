using Abp.Application.Services;

namespace coolez
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class coolezAppServiceBase : ApplicationService
    {
        protected coolezAppServiceBase()
        {
            LocalizationSourceName = coolezConsts.LocalizationSourceName;
        }
    }
}