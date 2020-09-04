using System;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string[] fileInfo = path.Split("\\").ToArray();

            string[] fileArgs = fileInfo.Last().Split('.', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] fileNameInfo = fileArgs.Take(fileArgs.Length - 1).ToArray();
            string fileName = string.Join('.', fileNameInfo);
            string fileExtension = fileArgs.Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
