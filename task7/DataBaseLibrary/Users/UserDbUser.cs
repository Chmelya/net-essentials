namespace DataBaseLibrary
{
    public class UserDbUser : IDbUser<IReadDatabase>
    {
        public UserDbUser()
        {

        }
        public void UseDatabase(IReadDatabase db)
        {
            db.ReadData();
        }
    }
}
