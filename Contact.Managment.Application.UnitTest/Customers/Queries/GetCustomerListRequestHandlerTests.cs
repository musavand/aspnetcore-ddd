using AutoMapper;
using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Appliaction.DTOs.Customer;
using Contact.Management.Appliaction.Features.Customer.Handlers.Queries;
using Contact.Management.Appliaction.Features.Customer.Requests.Queries;
using Contact.Management.Appliaction.Profiles;
using Contact.Managment.Application.UnitTest.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
namespace Contact.Managment.Application.UnitTest.Customers.Queries
{
    public class GetCustomerListRequestHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICustomerRepository> _mockRepo;

        public GetCustomerListRequestHandlerTests()
        {
            _mockRepo = MockCustomerRepository.GetCustomerRepository();
            var mapperConfig = new MapperConfiguration(
                c => c.AddProfile<MappingProfile>()          );
            _mapper = mapperConfig.CreateMapper();
        }
        [Fact]
        public async Task GetCustomerListTest()
        {
            var handler = new GetCustomerListRequestHandler(_mockRepo.Object,_mapper);
            var result = await handler.Handle(new GetCustomerListRequest(),CancellationToken.None);
            result.ShouldBeOfType<List<CustomerDto>>();
            result.Count.ShouldBe(2);
        }

    }
}
