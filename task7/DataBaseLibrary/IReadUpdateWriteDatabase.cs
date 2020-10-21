using System;

namespace DataBaseLibrary
{
    public interface IReadUpdateWriteDatabase : IDatabase
    {
        public string ReadData();
        public void WriteData(string data);
        public void UpdateData(Action<string> update);
    }
}
