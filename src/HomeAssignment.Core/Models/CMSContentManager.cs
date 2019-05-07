using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Models
{
   public class CMSContentManager:DomainService,ICMSContent
    {
        private readonly IRepository<CMSContent> _cmsRepository;
        public CMSContentManager(IRepository<CMSContent> cmsRepository)
        {
            _cmsRepository = cmsRepository;
        }

        public IEnumerable<CMSContent> GetAllList()
        {
            var cmsContentList = _cmsRepository.GetAllList();
                return cmsContentList;
        }

        public CMSContent GetCMSContentByID(int id)
        {
            var cmsContentById = _cmsRepository.Get(id);
            if (cmsContentById == null)
            {
                throw new UserFriendlyException("No Content Found with this Criteria");
            }
            else
            {
                return cmsContentById;
            }
        }

        public  async Task<CMSContent> InsertOrUpdate(CMSContent entity)
        {
            var cmsContent = _cmsRepository.FirstOrDefault(x =>x.Id == entity.Id);
            if (cmsContent != null)
            {
                throw new UserFriendlyException("Content Already Exit");
            }
            else { return await _cmsRepository.InsertAsync(entity); }
           
        }
    }
}
