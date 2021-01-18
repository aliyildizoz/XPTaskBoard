using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using FluentValidation;

namespace Business.Validation
{
    class TaskStateValidator : AbstractValidator<TaskState>
    {
        public TaskStateValidator()
        {
            RuleFor(ts => ts.Name).NotNull().NotEmpty();
        }
    }
}
