using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HomeAssignment.Configuration.Dto;

namespace HomeAssignment.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HomeAssignmentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
