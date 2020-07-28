using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPEasyWebCreation.Configuration.Dto;

namespace ABPEasyWebCreation.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPEasyWebCreationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
