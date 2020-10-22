namespace DataBaseLibrary
{
    public class ManagerDbUser : IDbUser<IReadUpdateDatabase>
    {
        public ManagerDbUser()
        {

        }

        public void UseDatabase(IReadUpdateDatabase db)
        {
            db.ReadData();
            db.UpdateData(data => data += "manager");
        }
    }
}
