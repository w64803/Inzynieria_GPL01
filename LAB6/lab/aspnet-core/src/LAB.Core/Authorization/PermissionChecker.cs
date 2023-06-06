using Abp.Authorization;
using LAB.Authorization.Roles;
using LAB.Authorization.Users;

namespace LAB.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
