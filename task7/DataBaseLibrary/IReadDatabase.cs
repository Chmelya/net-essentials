using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary
{
    public interface IReadDatabase : IDatabase
    {
        public string ReadData();
    }
}
