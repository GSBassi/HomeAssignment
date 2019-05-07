using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeAssignment.Models
{
  public  class CMSContent:FullAuditedEntity
    {
        private const int PageNameLength = 50;
        private const int PageContentLength = 2000;
        [Required]
        [StringLength(PageNameLength)]
        public string PageName { get; set; }
        [Required]
        [StringLength(PageContentLength)]
        public string PageContent { get; set; }
    }
}
