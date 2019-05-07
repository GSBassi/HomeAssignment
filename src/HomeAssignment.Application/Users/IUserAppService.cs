using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HomeAssignment.Roles.Dto;
using HomeAssignment.Users.Dto;

namespace HomeAssignment.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
