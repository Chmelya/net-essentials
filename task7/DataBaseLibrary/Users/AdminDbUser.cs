namespace DataBaseLibrary
{
    public class AdminDbUser : IDbUser<IReadUpdateWriteDatabase>
    {
        public AdminDbUser()
        {

        }
        public void UseDatabase(IReadUpdateWriteDatabase db)
        {
            db.ReadData();
            db.UpdateData(data => data += "admin");
            db.WriteData("admin write"); 
        }
    }
}
