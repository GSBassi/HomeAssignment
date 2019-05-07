using System.Threading.Tasks;
using HomeAssignment.Configuration.Dto;

namespace HomeAssignment.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
