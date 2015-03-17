namespace Point
{
    using System.IO;
    using System;

    /// <summary>
    /// Writes and reads List of Point3D in a text file
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

        public static Path LoadPath(string filePath)
        {
            var path = new Path();
            using (StreamReader reader = new StreamReader(@"../../storage.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] str = line.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var pointCoordinates = new double[3];

                    for (int i = 0; i < str.Length; i++)
                    {
                        pointCoordinates[i] = double.Parse(str[i]);
                    }

                    path.AddPoint(new Point3D( pointCoordinates[0], pointCoordinates[1], pointCoordinates[2]));
                }

                return path;
            }
        }
    }
}