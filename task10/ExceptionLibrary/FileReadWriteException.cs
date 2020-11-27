using System;

namespace ExceptionLibrary
{
    public class FileReadWriteException : Exception
    {
        public FileReadWriteException()
        {
            Console.WriteLine("Read or write file exception");
        }
        public FileReadWriteException(string message) : base(message)
        {

        }
        public FileReadWriteException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
