using System;

namespace DataBaseLibrary
{
    public class Database : IDatabase, IReadDatabase, IReadUpdateDatabase, IReadUpdateWriteDatabase
    {
        public string Shema { get; }
        private string _data;

        public Database()
        {
            _data = String.Empty;    
        }

        public string ReadData()
        {
            return _data;
        }
        public void WriteData(string data)
        {
            _data = data;
        }
        public void UpdateData(Func<string, string> update)
        {
            _data = update?.Invoke(_data);
        }
    }
}
