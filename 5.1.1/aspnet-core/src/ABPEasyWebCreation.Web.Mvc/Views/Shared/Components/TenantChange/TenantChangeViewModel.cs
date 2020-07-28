using Abp.AutoMapper;
using ABPEasyWebCreation.Sessions.Dto;

namespace ABPEasyWebCreation.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
