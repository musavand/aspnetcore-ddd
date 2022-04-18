using AutoMapper;
using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Appliaction.DTOs.Customer.Validators;
using Contact.Management.Appliaction.Features.Customer.Requests.Commands;
using Contact.Management.Appliaction.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Contact.Management.Domain;


namespace Contact.Management.Appliaction.Features.Customer.Handlers.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, BaseCommonResponse>
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly IMapper _mapper;
        public CreateCustomerCommandHandler(ICustomerRepository CustomerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _CustomerRepository = CustomerRepository;
        }

        public async Task<BaseCommonResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommonResponse();
            var validator = new CreateCustomerDtoValidator();
            var validateResult = await validator.ValidateAsync(request.customerDto);
            if (!validateResult.IsValid)
            {
                // throw new ValidationException(validateResult);
                response.Success = false;
                response.Message = "Customer Creation Failed";
                response.Errors = validateResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            var Customer = _mapper.Map<Contact.Management.Domain.Customer>(request.customerDto);
            var _Customer = await _CustomerRepository.Add(Customer);

            response.Success = false;
            response.Message = "Customer Creation Failed";
            response.Errors = validateResult.Errors.Select(q => q.ErrorMessage).ToList();
            response.id = _Customer.Id;
            return response;

        }
    }
}