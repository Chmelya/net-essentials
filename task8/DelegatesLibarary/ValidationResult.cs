using System.Collections.Generic;

namespace DelegatesLibarary
{
    public struct ValidationResult<T>
    {
        public T Entity { get; set; }
        public bool IsValid { get; set; }
        public IEnumerable<string> ErrorMessages { get; set; }
    }
}
