namespace Point
{
    using System.IO;

    /// <summary>
    /// Writes List of Point3D in a text file
    /// </summary>
    public static class PathStorage
    {
        public static void SavePath(Path anyPath)
        {
            using (StreamWriter sw = new StreamWriter(@"../../storage.txt"))
            {
                for (int i = 0; i < anyPath.GetPath.Count; i++)
                {
                    sw.WriteLine(anyPath.GetPath[i]);
                }
            }
        }
    }
}