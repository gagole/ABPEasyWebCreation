using System.Collections.Generic;
using ABPEasyWebCreation.Roles.Dto;

namespace ABPEasyWebCreation.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}