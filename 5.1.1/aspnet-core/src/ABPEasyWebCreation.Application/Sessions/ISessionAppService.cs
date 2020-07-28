using System.Threading.Tasks;
using Abp.Application.Services;
using ABPEasyWebCreation.Sessions.Dto;

namespace ABPEasyWebCreation.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
