using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace Contact.Management.Appliaction.DTOs.Customer.Validators
{
    class UpdateCustomerDtoValidator : AbstractValidator<CustomerDto>
    {
        public UpdateCustomerDtoValidator()
        {
            Include(new ICustomerDtoValidator());
            RuleFor(p => p.Id)
                .NotNull().WithMessage("{PropertyName}  must be ptesent");
        }
    }
}
