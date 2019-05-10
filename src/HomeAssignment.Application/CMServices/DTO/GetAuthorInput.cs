using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeAssignment.CMServices.DTO
{
  public  class GetAuthorInput
    {
        [Required]
        public int Id { get; set; }
    }
}
