namespace TraverseDirectories
{
    using System;
    using System.IO;

    public class EntryPoint
    {
        private static void PrintAllExeFiles(string directoryPath)
        {
            var folders = Directory.GetDirectories(directoryPath);
            var files = Directory.GetFiles(directoryPath);

            foreach (var file in files)
            {
                if (file.EndsWith(".exe"))
                {
                    Console.WriteLine(file);
                }
            }

            try
            {
                foreach (var folder in folders)
                {
                    PrintAllExeFiles(folder);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        public static void Main()
        {
            var rootPath = "C:\\WINDOWS";
            PrintAllExeFiles(rootPath);
        }
    }
}