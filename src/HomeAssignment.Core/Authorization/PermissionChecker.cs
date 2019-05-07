using Abp.Authorization;
using HomeAssignment.Authorization.Roles;
using HomeAssignment.Authorization.Users;

namespace HomeAssignment.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
