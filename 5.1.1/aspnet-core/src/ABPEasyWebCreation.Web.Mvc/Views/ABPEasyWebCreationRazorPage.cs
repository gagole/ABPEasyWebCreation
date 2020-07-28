using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ABPEasyWebCreation.Web.Views
{
    public abstract class ABPEasyWebCreationRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABPEasyWebCreationRazorPage()
        {
            LocalizationSourceName = ABPEasyWebCreationConsts.LocalizationSourceName;
        }
    }
}
