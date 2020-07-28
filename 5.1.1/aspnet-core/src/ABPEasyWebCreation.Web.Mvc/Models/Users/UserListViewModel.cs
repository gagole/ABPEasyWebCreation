using System.Collections.Generic;
using ABPEasyWebCreation.Roles.Dto;
using ABPEasyWebCreation.Users.Dto;

namespace ABPEasyWebCreation.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
