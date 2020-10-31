namespace DataBaseLibrary
{
    public interface IDbUser<T> 
        where T : IDatabase
    {
        string UseDatabase(T db);
    }
}
