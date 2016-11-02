using System.Linq;
using Northwind.Data;

namespace ExtendEmployee
{
    public class Startup
    {
        public static void Main()
        {
            var context = new NorthwindEntities();

            using (context)
            {
                var employee = context.Employees.FirstOrDefault();
                var extendedEmployee = new ExtendedEmployee(employee);
                var teritories = extendedEmployee.TerritoriesEntitySet;

                System.Console.WriteLine(teritories);
            }
        }
    }
}
