using System.Data.Linq;
using Northwind.Data;

namespace ExtendEmployee
{
    public class ExtendedEmployee
    {
        private readonly Employee employee;

        public ExtendedEmployee(Employee employee)
        {
            this.employee = employee;
        }

        public EntitySet<Territory> TerritoriesEntitySet
        {
            get
            {
                var teritories = new EntitySet<Territory>();
                teritories.AddRange(this.employee.Territories);
                return teritories;
            }
        }
    }
}
