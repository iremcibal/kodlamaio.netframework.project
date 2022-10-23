using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ValidationTool 
    {
        private readonly IValidator validator;

        public void Validate<TValidator, TRequest>(TRequest request)
        {
            var context = new ValidationContext<TRequest>(request);
            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }


        }
    }
}
