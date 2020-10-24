namespace DelegatesLibarary
{
    public interface IValidator<T>
    {
        ValidationResult<T> Validate(T entity);
    }
}
