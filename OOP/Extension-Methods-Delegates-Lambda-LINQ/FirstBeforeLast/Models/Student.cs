namespace FirstBeforeLast.Models
{
    class Student
    {
        public Student(string fName, string lName, int age)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
        }

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("First name: {0} | Last name: {1}", this.FirstName, this.LastName);
        }
    }
}