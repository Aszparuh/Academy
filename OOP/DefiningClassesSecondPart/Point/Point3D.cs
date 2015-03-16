using System;

namespace Point
{
    public struct Point3D
    {
        public static readonly Point3D PointO = new Point3D(0, 0, 0);
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format("(x = {0}, y = {1}, z = {2})", this.x, this.y, this.z);
        }
    }
}