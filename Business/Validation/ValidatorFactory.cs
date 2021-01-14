using System;
using System.Reflection;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ValidatorFactory : ValidatorFactoryBase
    {
        public override IValidator CreateInstance(Type validatorType)
        {
            return (IValidator)System.Reflection.Assembly.GetAssembly(validatorType).CreateInstance(validatorType.FullName);
        }
    }
}
