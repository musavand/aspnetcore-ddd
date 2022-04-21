using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Contact.Management.Identity.Models
{
    public class ApplicationUser  : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        ///and extra field for  user considered
    }
}
