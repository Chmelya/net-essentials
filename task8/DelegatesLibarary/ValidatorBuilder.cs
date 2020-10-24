using System;
using System.Collections.Generic;

namespace DelegatesLibarary
{
    public class ValidatorBuilder<T>: IValidatorBuilder<T>
    {
        private List<ValidationRule<T>> _rules;

        public ValidatorBuilder()
        {
            _rules = new List<ValidationRule<T>>();
        }

        public IValidatorBuilder<T> AddRule(Predicate<T> IsValid, Func<T, string> errorMessage)
        {
            _rules.Add(new ValidationRule<T>() { IsValid = IsValid, ErrorMessage = errorMessage });
            return this;
        }

        public IValidator<T> Build()
        {
            return new Validator<T>(_rules);
        }
    }
}
