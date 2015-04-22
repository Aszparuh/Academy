namespace StudentsAndWorkersLib.Models
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} => {1}", base.ToString(), this.Grade);
        }
    }
}