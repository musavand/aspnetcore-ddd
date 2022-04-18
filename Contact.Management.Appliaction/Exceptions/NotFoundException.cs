using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Appliaction.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        //customize constructort by 2 param but call  base ctor with 1 standard param
        public NotFoundException(string name, string key) : base($"{name}   ({key})   not found")
        {

        }
    }
}
