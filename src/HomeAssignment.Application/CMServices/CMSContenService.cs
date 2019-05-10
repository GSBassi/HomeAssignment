using Abp.Application.Services;
using Abp.Authorization;
using AutoMapper;
using HomeAssignment.CMServices.DTO;
using HomeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.CMServices
{
    [AbpAuthorize]

    public class CMSContenService : ApplicationService, ICMSContentAppService
    {
        private readonly ICMSContent _cmsManager;
        public CMSContenService(ICMSContent cmsManager)
        {
            _cmsManager = cmsManager;
        }

        public IEnumerable<GetCMSContentOutput> GetAll()
        {
            var getAll = _cmsManager.GetAllList().ToList();
            List<GetCMSContentOutput> output = Mapper.Map<List<CMSContent>, List<GetCMSContentOutput>>(getAll);
            return output;
        }

        public GetCMSContentOutput GetCMSContent(GetAuthorInput input)
        {
            var getCMS = _cmsManager.GetCMSContentByID(input.Id);
            GetCMSContentOutput output = Mapper.Map<CMSContent, GetCMSContentOutput>(getCMS);
            return output;
        }

        public async Task InsertOrUpdate(CreateContentInput input)
        {
            CMSContent output = Mapper.Map<CreateContentInput, CMSContent>(input);
            await _cmsManager.InsertOrUpdate(output);

        }
    }
}
