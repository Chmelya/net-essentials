using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary
{
    public class Database : IDatabase, IReadDatabase, IReadUpdateDatabase, IReadUpdateWriteDatabase
    {
        public string Shema { get; }
        private string Data { get; set; }

        public Database()
        {
            Data = String.Empty;    
        }

        public string ReadData()
        {
            return Data;
        }
        public void WriteData(string data)
        {
            Data += data;
        }
        public void UpdateData(Action<string> update)
        {
            update.Invoke(Data);
        }
    }
}
