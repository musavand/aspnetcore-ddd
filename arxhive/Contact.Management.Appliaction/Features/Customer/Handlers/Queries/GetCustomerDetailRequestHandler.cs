using Contact.Management.Appliaction.DTOs.Customer;
using Contact.Management.Appliaction.Features.Customer.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using Contact.Management.Appliaction.Contracts.Persistence;

namespace Contact.Management.Appliaction.Features.Customer.Handlers.Queries
{
    public class GetCustomerDetailRequestHandler : IRequestHandler<GetCustomerDetailRequest, CustomerDto>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        public int MyProperty { get; set; }
        public GetCustomerDetailRequestHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }
        public async Task<CustomerDto> Handle(GetCustomerDetailRequest request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.Get(request.Id);
            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
