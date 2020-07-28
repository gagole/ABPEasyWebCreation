using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPEasyWebCreation.Controllers
{
    public abstract class ABPEasyWebCreationControllerBase: AbpController
    {
        protected ABPEasyWebCreationControllerBase()
        {
            LocalizationSourceName = ABPEasyWebCreationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
