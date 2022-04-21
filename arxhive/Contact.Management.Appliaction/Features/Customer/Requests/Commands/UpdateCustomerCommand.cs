using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Management.Appliaction.DTOs.Customer;
using MediatR;

namespace Contact.Management.Appliaction.Features.Customer.Requests.Commands
{
    public class UpdateCustomerCommand : IRequest<Unit>
    {
        public CustomerDto customerDto { get; set; }
    }
}
