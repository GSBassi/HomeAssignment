using Abp.Application.Services.Dto;

namespace HomeAssignment.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

