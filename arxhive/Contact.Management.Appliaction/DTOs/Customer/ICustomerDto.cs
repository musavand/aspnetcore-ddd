using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Appliaction.DTOs.Customer
{
    public interface ICustomerDto
    {

        public String? Firstname { get; set; }
        public String? Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String? PhoneNumber { get; set; }
        public String? Email { get; set; }

        public String? BankAccountNumber { get; set; }
    }
}
