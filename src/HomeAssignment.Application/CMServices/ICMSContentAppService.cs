using Abp.Application.Services;
using HomeAssignment.CMServices.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.CMServices
{
    interface ICMSContentAppService:IApplicationService
    {
        IEnumerable<GetCMSContentOutput> GetAll();
        Task InsertOrUpdate(CreateContentInput input);
        GetCMSContentOutput GetCMSContent(GetAuthorInput input);
    }
}
