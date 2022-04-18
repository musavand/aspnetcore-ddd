using AutoMapper;
using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Appliaction.Features.Customer.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Contact.Management.Appliaction.DTOs.Customer.Validators;
using Contact.Management.Appliaction.Exceptions;

namespace Contact.Management.Appliaction.Features.Customer.Handlers.Commands
{
   public  class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateCustomerCommand, Unit>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateCustomerDtoValidator();
            var validateResult = await validator.ValidateAsync(request.customerDto);
            if (!validateResult.IsValid)
                throw new ValidationException(validateResult);

            var leaveType = await _customerRepository.Get(request.customerDto.Id);
            _mapper.Map(request.customerDto, leaveType);
            await _customerRepository.Update(leaveType);
            return Unit.Value;
        }
    }
}
