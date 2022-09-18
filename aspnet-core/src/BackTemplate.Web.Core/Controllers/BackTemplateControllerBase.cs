using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BackTemplate.Controllers
{
    public abstract class BackTemplateControllerBase: AbpController
    {
        protected BackTemplateControllerBase()
        {
            LocalizationSourceName = BackTemplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
