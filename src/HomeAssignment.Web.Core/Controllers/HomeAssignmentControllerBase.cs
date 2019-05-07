using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HomeAssignment.Controllers
{
    public abstract class HomeAssignmentControllerBase: AbpController
    {
        protected HomeAssignmentControllerBase()
        {
            LocalizationSourceName = HomeAssignmentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
