using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LAB.Configuration.Dto;

namespace LAB.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LABAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
