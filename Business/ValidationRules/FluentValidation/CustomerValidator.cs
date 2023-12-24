using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.Surname).NotEmpty();
            RuleFor(c => c.Surname).MinimumLength(2);
            RuleFor(c => c.NationalId).NotEmpty();
            RuleFor(c => c.NationalId).Length(11);
        }
    }
}
