namespace BuildTreeFilesDirectories
{
    public class File
    {
        public File(int size, string name)
        {
            this.Size = size;
            this.Name = name;
        }

        public int Size { get; set; }

        public string Name { get; set; }
    }
}