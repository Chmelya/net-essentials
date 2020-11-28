using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ExceptionLibrary
{
    [Serializable]
    public static class FileManager
    {
        public static void ReadAll(FileStream fileStream)
        {
            if (fileStream == null)
            {
                throw new FileReadWriteException("FileStream is null");
            }

            for (int i = 0; i < fileStream.Length; i++)
            {
                Console.WriteLine(fileStream.ReadByte().ToString());
            }
        }

        public static void CreateTxtFile(string fileName)
        {
            try
            {
                if (fileName.Split('.')[1] != "txt")
                {
                    throw new FileReadWriteException("It's not a txt file");
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new FileReadWriteException("It's not a txt file", ex);
            }

            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            fileStream.Close();
        }
    }
}
