using System;

namespace Point3D
{
    public struct Point3D
    {
        public static readonly Point3D PointO = new Point3D(0, 0, 0);
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.x, this.y, this.z);
        }
    }
}