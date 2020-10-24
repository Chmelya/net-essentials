using System;

namespace DelegatesLibarary
{
    public struct ValidationRule<T>
    {
        public Predicate<T> IsValid { get; set; }
        public Func<T, string> ErrorMessage { get; set; }
    }

}
