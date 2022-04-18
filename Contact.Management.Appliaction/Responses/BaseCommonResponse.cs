using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Appliaction.Responses
{
   public class BaseCommonResponse
    {
        public int id { get; set; }
        public bool Success { get; set; }
        public String Message { get; set; }

        public List<String> Errors { get; set; }
    }
}
