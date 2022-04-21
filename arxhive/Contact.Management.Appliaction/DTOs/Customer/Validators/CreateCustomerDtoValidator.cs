using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace Contact.Management.Appliaction.DTOs.Customer.Validators
{
    public class CreateCustomerDtoValidator : AbstractValidator<CreateCustomerDto>
    {
        public CreateCustomerDtoValidator()
        {
            Include(new ICustomerDtoValidator());

        }
    }
}