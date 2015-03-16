using System;
using System.Collections.Generic;

namespace Point
{
    public class Path
    {
        private List<Point3D> pathList;

        public Path()
        {
            this.pathList = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.pathList.Add(point);
        }

        public void ClearPath()
        {
            this.pathList.Clear();
        }

        public List<Point3D> GetPath()
        {
            return this.pathList;
        }
    }
}