using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Contact.Management.Appliaction.DTOs.Customer.Validators
{
    public class ICustomerDtoValidator : AbstractValidator<ICustomerDto>
    {
        public ICustomerDtoValidator()
        {
            RuleFor(p => p.Firstname)
                .NotEmpty().WithMessage("{PropertyName}  is Required.")
                .NotNull()
                .MaximumLength(20).WithMessage("{PropertyName}  Exceded Than {ComparisonValue} Characters.");

            RuleFor(p => p.Lastname)
               .NotEmpty().WithMessage("{PropertyName}  is Required.")
               .NotNull()
               .MaximumLength(20).WithMessage("{PropertyName}  Exceded Than {ComparisonValue} Characters.");

            RuleFor(p => p.PhoneNumber)
               .NotEmpty().WithMessage("{PropertyName}  is Required.")
               .NotNull()
               .MaximumLength(15).WithMessage("{PropertyName}  Exceded Than {ComparisonValue} Characters.");

            RuleFor(p => p.BankAccountNumber)
               .NotEmpty().WithMessage("{PropertyName}  is Required.")
               .NotNull()
               .MaximumLength(10).WithMessage("{PropertyName}  Exceded Than {ComparisonValue} Characters.");

            RuleFor(p => p.Email)
              .NotEmpty().WithMessage("{PropertyName}  is Required.")
              .NotNull()
              .MaximumLength(50).WithMessage("{PropertyName}  Exceded Than {ComparisonValue} Characters.");

            /*
            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage(" {PropertyName}  is Required")
                .NotNull()
                .LessThan(1).WithMessage(" {PropertyName}  must grathar than {ComparisonValue}")
                .GreaterThan(31).WithMessage("{PropertyName}  must less than {ComparisonValue}");
            */
        }
    }
}
