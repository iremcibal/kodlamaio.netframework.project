using Business.Request.Category;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationResolvers.FluentValidation.Category
{
    public class CreateCategoryRequestValidator : AbstractValidator<CreateCategoryRequest>
    {
        public CreateCategoryRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).MinimumLength(3);

            RuleFor(x => x.Description).Must(StartsWithA);
        }

        private bool StartsWithA(string description)
        {
            return description.StartsWith("A");
        }
    }
}
