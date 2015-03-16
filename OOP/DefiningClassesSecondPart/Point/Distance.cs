using System;

namespace Point
{
    public static class Distance
    {
        public static double CalcDistance(Point3D firstP, Point3D secondP)
        {
            return Math.Sqrt((firstP.X - secondP.X) * (firstP.X - secondP.X) +
                             (firstP.Y - secondP.Y) * (firstP.Y - secondP.Y) +
                             (firstP.Z - secondP.Z) * (firstP.Z - secondP.Z));
        }
    }
}