using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeAssignment.CMServices.DTO
{
    public class CreateContentInput
    {
        //public int Id { get; set; }
        [Required]
        public string pageName { get; set; }
        [Required]
        public string pageContent { get; set; }
    }
}
