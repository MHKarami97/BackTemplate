using Abp.Authorization;
using BackTemplate.Authorization.Roles;
using BackTemplate.Authorization.Users;

namespace BackTemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
