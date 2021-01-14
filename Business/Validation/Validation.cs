using Business.ValidationRules.FluentValidation;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Validation
{
    public class Validation<TValidator> where TValidator : class, IValidator, new()
    {
        public void Validate(object entity)
        {
            ValidatorFactory factory = new ValidatorFactory();
            IValidator validator = factory.CreateInstance(typeof(TValidator));
            IValidationContext context = new ValidationContext<object>(entity);
            var validateResult = validator.Validate(context);
            if (!validateResult.IsValid)
            {
                throw new ValidationException(validateResult.Errors);
            }
        }
    }
}
