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
            RuleFor(t => t.Details).NotNull().NotEmpty();
            RuleFor(t => t.TaskStateId).NotNull().NotEmpty();
            RuleFor(t => t.ProjectId).NotNull().NotEmpty();
            RuleFor(t => t.Id).NotNull();
            RuleFor(t => t.EstimatedDate).NotNull().NotEmpty();
        }
    }
}
