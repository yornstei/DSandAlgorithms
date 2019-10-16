using System;
using System.IO;

namespace Algorithms
{
    static class Recursion
    {
        public static int CountOfTxtFilesInDir(string dirPath)
        {
            var txtFiles = Directory.GetFiles(dirPath, "*.txt");
            int txtFilesCount = txtFiles.Length;

            foreach (var dir in Directory.GetDirectories(dirPath))
                txtFilesCount += CountOfTxtFilesInDir(dir);

            return txtFilesCount;
        }

        public static void PrintTxtFilesInDir(string dirPath)
        {
            var txtFiles = Directory.GetFiles(dirPath, "*.txt");
            foreach (var txtFile in txtFiles)
                Console.WriteLine(txtFile);

            foreach (var dir in Directory.GetDirectories(dirPath))
                PrintTxtFilesInDir(dir);
        }
    }
}
