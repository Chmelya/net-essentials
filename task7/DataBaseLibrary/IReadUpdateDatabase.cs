using System;

namespace DataBaseLibrary
{
    public interface IReadUpdateDatabase : IDatabase
    {
        public string ReadData();
        public void UpdateData(Action<string> update);
    }
}
