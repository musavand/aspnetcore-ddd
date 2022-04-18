using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Managment.MVC.Models
{
    public class CustomerVM : CreateCustomerVM
    {
        public int Id { get; set; }
    }
        public class CreateCustomerVM
    {
      
        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "BankAccountNumber")]
        public string BankAccountNumber { get; set; }


        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }
    }

}
