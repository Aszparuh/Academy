namespace Point
{
    /// <summary>
    /// A structure that holds a 3D-coordinate {X, Y, Z} in the Euclidean 3D space.
    /// </summary>
    public struct Point3D
    {
        public static readonly Point3D PointO = new Point3D(0, 0, 0);
        
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})", this.X, this.Y, this.Z);
        }
    }
}