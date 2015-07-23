namespace QualityMethods.Models
{
    using System;

    public class Student : IComparable
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public DateTime DateOfBirth { get; private set; }

        public string FirstName
        {
            get 
            {
                return this.firstName;
            }
            set 
            {
                this.IsNullOrEmpty(value, "First name");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.IsNullOrEmpty(value, "Last name");
                this.lastName = value;
            }
        }

        public int CompareTo(object student)
        {
            if (student == null)
            {
                throw new ArgumentException("You cannot compare with null");
            }

            Student studentToCompare = student as Student;
            if (studentToCompare != null)
            {
                return this.DateOfBirth.CompareTo(studentToCompare.DateOfBirth);
            }
            else
            {
                throw new ArgumentException("The object is not Student");
            }
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}, Last Name: {1}, Birth Date: {2}", this.FirstName, this.LastName, this.DateOfBirth);
        }

        private void IsNullOrEmpty(string name, string parameter)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or white space", parameter);
            }
        }
    }
}