using System.Collections.Generic;

namespace DelegatesLibarary
{
    public class Validator<T>: IValidator<T>
    {
        public readonly List<ValidationRule<T>> _rules;

        public Validator(List<ValidationRule<T>> rules)
        {
            _rules = rules;
        }
        public ValidationResult<T> Validate(T entity)
        {
            bool isValid = true;
            var errorMessages = new List<string>();

            foreach (var item in _rules)
            {
                if (!item.IsValid(entity))
                {
                    isValid = false;
                    errorMessages.Add(item.ErrorMessage(entity));
                }
            }

            return new ValidationResult<T>()
            {
                Entity = entity,
                IsValid = isValid,
                ErrorMessages = errorMessages
            };
        }
    }
}
