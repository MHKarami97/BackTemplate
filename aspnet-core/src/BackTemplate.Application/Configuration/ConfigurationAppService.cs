using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BackTemplate.Configuration.Dto;

namespace BackTemplate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BackTemplateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
