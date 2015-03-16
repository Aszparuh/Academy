using System;

namespace Point
{
    public static class Distance
    {
        public static double CalcDistance(Point3D firstP, Point3D secondP)
        {
            return Math.Sqrt((firstP.x - secondP.x) * (firstP.x - secondP.x) +
                             (firstP.y - secondP.y) * (firstP.y - secondP.y) +
                             (firstP.z - secondP.z) * (firstP.z - secondP.z));
        }
    }
}