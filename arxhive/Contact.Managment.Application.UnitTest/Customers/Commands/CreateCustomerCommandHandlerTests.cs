using AutoMapper;
using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Appliaction.DTOs.Customer;
using Contact.Management.Appliaction.Features.Customer.Handlers.Commands;
using Contact.Management.Appliaction.Features.Customer.Handlers.Queries;
using Contact.Management.Appliaction.Features.Customer.Requests.Commands;
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

namespace Contact.Managment.Application.UnitTest.Customers.Commands
{
    public  class CreateCustomerCommandHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<ICustomerRepository> _mockRepo;
        private readonly CreateCustomerDto _customerDto;
        public CreateCustomerCommandHandlerTests()
        {
            _mockRepo = MockCustomerRepository.GetCustomerRepository();
            var mapperConfig = new MapperConfiguration(
                c => c.AddProfile<MappingProfile>());
            _mapper = mapperConfig.CreateMapper();

            _customerDto = new CreateCustomerDto
            {
                //Id = 3,
                BankAccountNumber = "1234567899",
                Email = "mehdi@gmail..com",
                DateOfBirth = DateTime.Now,
                Firstname = "mehdi",
                Lastname = "asadi",
                //CreateBy = "admin",
                //DateCreated = DateTime.Now,
                //LastModifyDate = DateTime.Now,
                //ModifyBy = "admin",
                PhoneNumber = "09124543157"
            };
        }

        [Fact]
        public async Task CreateCustomerTest()
        {
            var handler = new CreateCustomerCommandHandler(_mockRepo.Object, _mapper);
            var result = await handler.Handle(new CreateCustomerCommand() {
             customerDto = _customerDto

            }, CancellationToken.None);
            var customers = await _mockRepo.Object.GetAll();

            result.ShouldBeOfType<int>();
            customers.Count.ShouldBe(3);
        }

    }
}
