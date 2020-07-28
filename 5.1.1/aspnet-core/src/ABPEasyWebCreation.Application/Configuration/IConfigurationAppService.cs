using System.Threading.Tasks;
using ABPEasyWebCreation.Configuration.Dto;

namespace ABPEasyWebCreation.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
