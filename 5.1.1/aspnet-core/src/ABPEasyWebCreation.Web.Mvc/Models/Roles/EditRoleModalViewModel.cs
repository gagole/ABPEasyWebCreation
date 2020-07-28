using Abp.AutoMapper;
using ABPEasyWebCreation.Roles.Dto;
using ABPEasyWebCreation.Web.Models.Common;

namespace ABPEasyWebCreation.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
