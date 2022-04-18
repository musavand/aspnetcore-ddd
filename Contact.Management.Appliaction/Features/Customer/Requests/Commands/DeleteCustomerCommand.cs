using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Appliaction.Features.Customer.Requests.Commands
{
    public class DeleteCustomerCommand : IRequest
    {
        public int Id { get; set; }
    }
}
