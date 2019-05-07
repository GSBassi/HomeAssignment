using System.Threading.Tasks;
using Abp.Application.Services;
using HomeAssignment.Authorization.Accounts.Dto;

namespace HomeAssignment.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
