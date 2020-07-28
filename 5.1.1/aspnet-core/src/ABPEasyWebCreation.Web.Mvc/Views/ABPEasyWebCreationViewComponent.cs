using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABPEasyWebCreation.Web.Views
{
    public abstract class ABPEasyWebCreationViewComponent : AbpViewComponent
    {
        protected ABPEasyWebCreationViewComponent()
        {
            LocalizationSourceName = ABPEasyWebCreationConsts.LocalizationSourceName;
        }
    }
}
