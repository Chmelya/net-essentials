namespace DataBaseLibrary
{
    public interface IDatabase
    {
        public string Shema { get; }
        public string ReadData();
    }
}
