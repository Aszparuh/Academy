namespace TriangleSurfaceBySideAndAltitude
{
    using System;

    class Start
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            var area = (side * altitude) / 2;
            Console.WriteLine("{0:0.00}", area);
        }
    }
}
