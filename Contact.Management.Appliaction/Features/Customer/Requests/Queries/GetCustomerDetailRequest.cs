using Contact.Management.Appliaction.DTOs.Customer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Appliaction.Features.Customer.Requests.Queries
{
    public class GetCustomerDetailRequest : IRequest<CustomerDto>
    {
        public int Id { get; set; }
        public GetCustomerDetailRequest()
        {

        }
    }
}
