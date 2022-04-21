using Contact.Management.Appliaction.DTOs.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Contact.Managment.MVC.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }

        Task CustomerPOSTAsync(CreateCustomerDto createCustomer);
    }
}
