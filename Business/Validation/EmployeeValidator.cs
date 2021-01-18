using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using FluentValidation;

namespace Business.Validation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(user => user.FirstName).NotNull().MaximumLength(100).NotEmpty();
            RuleFor(user => user.LastName).NotNull().MaximumLength(100).NotEmpty();
        }
    }
}
