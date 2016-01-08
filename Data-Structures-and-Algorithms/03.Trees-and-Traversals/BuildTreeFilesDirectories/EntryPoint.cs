namespace BuildTreeFilesDirectories
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class EntryPoint
    {
        public static void Main()
        {
            var path = "C:\\WINDOWS";
            var startingFolder = new Folder(path);
            CreateTree(startingFolder);
            var size = CalculateSize(startingFolder);
            Console.WriteLine(size);
        }

        private static void CreateTree(Folder folder)
        {
            var folderInfo = new DirectoryInfo(folder.Name);
            var subFiles = new List<File>();
            var subFolders = new List<Folder>();

            FileInfo[] containedFIlesInfo = folderInfo.GetFiles();
            foreach (FileInfo file in containedFIlesInfo)
            {
                int size = (int)file.Length;
                var fileToAdd = new File(size, file.Name);
                subFiles.Add(fileToAdd);
            }

            folder.Files = subFiles.ToArray();

            foreach (var subfolder in Directory.GetDirectories(folder.Name))
            {
                var folderToAdd = new Folder(subfolder);
                subFolders.Add(folderToAdd);
                CreateTree(folderToAdd);
            }

            folder.Folders = subFolders.ToArray();
        }

        private static int CalculateSize(Folder folder, int size = 0)
        {
            foreach (var file in folder.Files)
            {
                size += file.Size;
            }

            foreach (var subfolder in folder.Folders)
            {
                size += CalculateSize(subfolder);
            }

            return size;
        }
    }
}