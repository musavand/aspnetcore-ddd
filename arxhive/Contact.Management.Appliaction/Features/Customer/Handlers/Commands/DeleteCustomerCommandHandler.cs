using AutoMapper;
using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Appliaction.Exceptions;
using Contact.Management.Appliaction.Features.Customer.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Contact.Management.Appliaction.Features.Customer.Handlers.Commands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _customerRepository.Get(request.Id);
            if (leaveType == null)
                throw new NotFoundException(nameof(leaveType), request.Id.ToString());
            await _customerRepository.Delete(leaveType);
            return Unit.Value;
        }
    }
}
