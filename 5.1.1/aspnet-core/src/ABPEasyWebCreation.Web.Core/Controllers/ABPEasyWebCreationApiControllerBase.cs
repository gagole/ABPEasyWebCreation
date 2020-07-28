using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPEasyWebCreation.Controllers
{
    public class ABPEasyWebCreationApiControllerBase : AbpController
    {
        public ABPEasyWebCreationApiControllerBase()
        {
            LocalizationSourceName = ABPEasyWebCreationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
