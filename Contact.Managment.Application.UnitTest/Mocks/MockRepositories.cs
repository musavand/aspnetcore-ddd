using Contact.Management.Appliaction.Contracts.Persistence;
using Contact.Management.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Managment.Application.UnitTest.Mocks
{
    public static class MockCustomerRepository
    {
        public static Mock<ICustomerRepository> GetCustomerRepository()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id=1,
                    BankAccountNumber="1234567890",
                    Email="mehdi@yahoo.com",
                    DateOfBirth = DateTime.Now,
                    Firstname="mehdi",
                    Lastname="musavand",
                    CreateBy="admin",
                    DateCreated=DateTime.Now,
                    LastModifyDate=DateTime.Now,
                    ModifyBy="admin",
                    PhoneNumber="09124543156"
                },
                new Customer
                {
                    Id = 2,
                    BankAccountNumber = "1234567899",
                    Email = "mehdi@gmail..com",
                    DateOfBirth = DateTime.Now,
                    Firstname = "mehdi",
                    Lastname = "asadi",
                    CreateBy = "admin",
                    DateCreated = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    ModifyBy = "admin",
                    PhoneNumber = "09124543157"
                }
            };
            var mockRepo = new Mock<ICustomerRepository>();
            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(customers);
            mockRepo.Setup(r => r.Add(It.IsAny<Customer>())).ReturnsAsync((Customer customer) =>
            {
                customers.Add(customer);
                return customer;
            }         
            );
            return mockRepo;
        }
    }
}
