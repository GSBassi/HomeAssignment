using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAssignment.CMServices.DTO
{
   public class GetCMSContentOutput
    {
        public int Id { get; set; }
        public string pageName { get; set; }
        public string pageContent { get; set; }
    }
}
