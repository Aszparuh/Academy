namespace StudentGroups
{
    /*Create a class Student with properties 
      FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.*/
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fNumber;
        private string tel;
        private string email;
        private Dictionary<string, double> marks = new Dictionary<string,double>();
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
            set 
            {
                int number;
                if (!int.TryParse(value, out number))
                {
                    throw new ArgumentException("Faculty Number is not valid.");
                }

                this.fNumber = value;
            }
        }

        public string Telephone
        {
            get { return this.tel; }
            set 
            {
                if (!Regex.IsMatch(value.Trim(), @"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})"))
                {
                    throw new ArgumentException("Invalid phone!");
                }

                this.tel = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set 
            {
                if (!Regex.IsMatch(value.Trim(),
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) //https://msdn.microsoft.com/en-us/library/01escwtf%28v=vs.110%29.aspx
                {
                    throw new ArgumentException("Invalid email!");
                }
                this.email = value;
            }
        }

        public Dictionary<string, double> Marks
        {
            get { return new Dictionary<string, double>(this.marks); }
        }

        public int Group
        {
            get {return this.groupNumber;}
            set {this.groupNumber = value;}
        }

        public void AddMark(string discipline, int grade)
        {
            marks.Add(discipline, grade);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}