using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Management.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.Management.Persistence.Configurations.Entities
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
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
                );
        }
    }
}
