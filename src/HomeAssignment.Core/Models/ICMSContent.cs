using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Models
{
   public interface ICMSContent:IDomainService
    {
        IEnumerable<CMSContent> GetAllList();
        CMSContent GetCMSContentByID(int id);
        Task<CMSContent> InsertOrUpdate(CMSContent entity);
    }
}
