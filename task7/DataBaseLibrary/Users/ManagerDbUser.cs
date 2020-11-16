using System;

namespace DataBaseLibrary
{
    public class ManagerDbUser : IDbUser<IReadUpdateDatabase>
    {
        public string UseDatabase(IReadUpdateDatabase db)
        {
            db.UpdateData(data => data += "manager update");
            return db.ReadData();
        }
    }
}
