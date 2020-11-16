using System;

namespace DelegatesLibarary
{
    public interface IValidatorBuilder<T>
    {
        IValidatorBuilder<T> AddRule(Predicate<T> IsValid, Func<T, string> errorMessage);
        IValidator<T> Build();
    }
}
