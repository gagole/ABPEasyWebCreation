using System.Collections.Generic;
using ABPEasyWebCreation.Roles.Dto;

namespace ABPEasyWebCreation.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
