using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using FluentValidation;

namespace Business.Validation
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(p => p.Name).NotNull();
        }
    }
}
