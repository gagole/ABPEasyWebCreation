using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPEasyWebCreation.MultiTenancy.Dto;

namespace ABPEasyWebCreation.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

