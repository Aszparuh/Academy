namespace StudentGroups
{
    /*Create a class Student with properties 
      FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.*/
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fNumber;
        private string tel;
        private string email;
        private List<double> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, string fNumber, string tel, string email, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = fNumber;
            this.Telephone = tel;
            this.Email = email;
            this.Group = group;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name should not be empty or null.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name should not be empty or null.");
                }

                this.lastName = value;
            }
        }

        public string FacultyNumber
        {
            get { return this.fNumber; }
            set { this.fNumber = value; }
        }

        public string Telephone
        {
            get { return this.tel; }
            set { this.tel = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public List<double> Marks
        {
            get { return new List<double>(this.marks); }
        }

        public int Group
        {
            get {return this.groupNumber;}
            set {this.groupNumber = value;}
        }
    }
}