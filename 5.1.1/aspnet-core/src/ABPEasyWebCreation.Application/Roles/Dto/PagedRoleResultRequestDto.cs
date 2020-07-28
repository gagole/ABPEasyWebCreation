using Abp.Application.Services.Dto;

namespace ABPEasyWebCreation.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

