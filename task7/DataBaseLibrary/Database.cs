using System;
using System.Collections.Generic;
using System.Text;

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
            Console.WriteLine(_data);
            return _data;
        }
        public void WriteData(string data)
        {
            _data = data;
            Console.WriteLine(_data);
        }
        public void UpdateData(Func<string, string> update)
        {
            _data = update?.Invoke(_data);
        }
    }
}
