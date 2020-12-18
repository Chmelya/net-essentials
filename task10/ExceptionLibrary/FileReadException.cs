using System;

namespace ExceptionLibrary
{
    public class FileReadException : Exception
    {
        public FileReadException()
        {
            Console.WriteLine("Read or write file exception");
        }
        public FileReadException(string message) : base(message)
        {

        }
        public FileReadException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
