using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeAssignment.CMServices.DTO
{
    public class CreateContentInput
    {
        //public int Id { get; set; }
        private const int PageNameLength = 50;
        private const int PageContentLength = 2000;
        [Required]
        [StringLength(PageNameLength)]
        public string pageName { get; set; }
        [Required]
        [StringLength(PageContentLength)]
        public string pageContent { get; set; }
    }
}
