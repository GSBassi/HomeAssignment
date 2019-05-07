using System.Threading.Tasks;
using Abp.Application.Services;
using HomeAssignment.Sessions.Dto;

namespace HomeAssignment.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
