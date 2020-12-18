using System;

namespace ExceptionLibrary
{
    public class FileWriteException : Exception
    {
        public FileWriteException()
        {
            Console.WriteLine("Write file exception");
        }
        public FileWriteException(string message) : base(message)
        {

        }
        public FileWriteException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
