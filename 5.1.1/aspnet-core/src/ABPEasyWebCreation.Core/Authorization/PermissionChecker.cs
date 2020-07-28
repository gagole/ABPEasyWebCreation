using Abp.Authorization;
using ABPEasyWebCreation.Authorization.Roles;
using ABPEasyWebCreation.Authorization.Users;

namespace ABPEasyWebCreation.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
