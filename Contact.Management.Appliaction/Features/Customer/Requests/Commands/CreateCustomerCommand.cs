using Contact.Management.Appliaction.DTOs.Customer;
using Contact.Management.Appliaction.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Appliaction.Features.Customer.Requests.Commands
{
    public class CreateCustomerCommand : IRequest<BaseCommonResponse>
    {
        public CreateCustomerDto customerDto { get; set; }
    }
}
