using AutoMapper;
using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Appliaction.DTOs.Customer;
using Contact.Management.Appliaction.Features.Customer.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Contact.Management.Appliaction.Features.Customer.Handlers.Queries
{
    public class GetCustomerListRequestHandler : IRequestHandler<GetCustomerListRequest, List<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerListRequestHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<List<CustomerDto>> Handle(GetCustomerListRequest request, CancellationToken cancellationToken)
        {
            var customers = await _customerRepository.GetAll();
            return _mapper.Map<List<CustomerDto>>(customers);
        }

       
    }
}