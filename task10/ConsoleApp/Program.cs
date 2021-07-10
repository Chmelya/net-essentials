using System;
using System.IO;
using ExceptionLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = null;

            try
            {
                FileManager.CreateTxtFile("file.txt");

                fileStream = new FileStream("file.txt", FileMode.OpenOrCreate);

                FileManager.ReadAll(fileStream);
            }
            catch (FileWriteException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (FileReadException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch
            {
                throw;
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}
