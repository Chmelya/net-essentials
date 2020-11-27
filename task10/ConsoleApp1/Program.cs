using System;
using System.IO;
using ExceptionLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream;

            try
            {
                Example.CreateTxtFile("file");
            }
            catch(FileReadWriteException)
            {
                Console.WriteLine("File not created");
            }


            fileStream = null;
            
            try
            {
                Example.ReadAll(fileStream);
            }
            catch(FileReadWriteException)
            {
                fileStream = new FileStream("file.txt", FileMode.OpenOrCreate);
            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}
