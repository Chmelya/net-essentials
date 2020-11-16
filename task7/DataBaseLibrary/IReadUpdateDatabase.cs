using System;

namespace DataBaseLibrary
{
    public interface IReadUpdateDatabase : IDatabase
    {
        public string ReadData();
        public void UpdateData(Func<string, string> update);
    }
}
