using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HomeAssignment.MultiTenancy.Dto;

namespace HomeAssignment.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

