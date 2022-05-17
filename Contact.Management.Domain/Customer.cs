using Contact.Management.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Domain
{
    public class Customer : BaseDomainEntity
    {
        private string _Firstname;
        private string _Lastname;
        private string _Email;
        private string _BankAccountNumber;

        public String? Firstname { get { return _Firstname.ToUpper(); } set { _Firstname = value; } }
        public String? Lastname { get { return _Lastname.ToUpper(); } set { _Lastname = value; } }
        public DateTime DateOfBirth { get; set; }
        public String? PhoneNumber { get; set; }
        public String? Email { get { return _Email.ToUpper(); } set { _Email = value; } }

        public String? BankAccountNumber { get { return _BankAccountNumber.ToUpper(); } set { _BankAccountNumber = value; } }







    }
}
