namespace Point
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pathList;

        public Path()
        {
            this.pathList = new List<Point3D>();
        }

        public List<Point3D> GetPath
        {
            get { return this.pathList; }
        }

        public void AddPoint(Point3D point)
        {
            this.pathList.Add(point);
        }

        public void ClearPath()
        {
            this.pathList.Clear();
        }
    }
}