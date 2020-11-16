using System;

namespace DataBaseLibrary
{
    public class AdminDbUser : IDbUser<IReadUpdateWriteDatabase>
    {
        public string UseDatabase(IReadUpdateWriteDatabase db)
        {
            db.UpdateData(data => data += "admin update");
            db.WriteData("admin write");
            return db.ReadData();
        }
    }
}
