using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace ABPEasyWebCreation.Authorization
{
    public class ABPEasyWebCreationAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            var employessPermission = context.CreatePermission(PermissionNames.Pages_Employee_List, L("EmployeeList"));
            employessPermission.CreateChildPermission(PermissionNames.Pages_Employee_Detail, L("EmployeeDetail"));
            employessPermission.CreateChildPermission(PermissionNames.Pages_Employee_Create, L("EmployeeCreate"));
            employessPermission.CreateChildPermission(PermissionNames.Pages_Employee_Update, L("EmployeeUpdate"));
            employessPermission.CreateChildPermission(PermissionNames.Pages_Employee_Delete, L("EmployeeDelete"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ABPEasyWebCreationConsts.LocalizationSourceName);
        }
    }
}
