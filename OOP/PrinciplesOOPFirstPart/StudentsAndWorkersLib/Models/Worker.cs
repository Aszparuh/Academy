namespace StudentsAndWorkersLib.Models
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public double MoneyPerHour()
        {
            double paymentPerDay = this.WeekSalary / 7;
            return paymentPerDay / this.WorkHoursPerDay; 
        }

        public override string ToString()
        {
            return string.Format("{0} => {1:F2}", base.ToString(), this.MoneyPerHour());
        }
    }
}