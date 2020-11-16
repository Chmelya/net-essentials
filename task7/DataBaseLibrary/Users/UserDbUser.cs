using System;

namespace DataBaseLibrary
{
    public class UserDbUser : IDbUser<IReadDatabase>
    {
        public string UseDatabase(IReadDatabase db)
        {
            return db.ReadData();
        }
    }
}
