using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LAB.Controllers
{
    public abstract class LABControllerBase: AbpController
    {
        protected LABControllerBase()
        {
            LocalizationSourceName = LABConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
