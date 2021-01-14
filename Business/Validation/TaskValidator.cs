using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using FluentValidation;

namespace Business.Validation
{
    public class TaskValidator : AbstractValidator<Task>
    {
        public TaskValidator()
        {
            RuleFor(t => t.Details).NotNull();
        }
    }
}
