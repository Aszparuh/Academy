namespace SchoolSysytemLib.Models
{
    using System;

    public class Person : BaseSchoolAbs
    {
        private string lastName;

        public Person(string firstName, string lastName) : base(firstName)
        {
            this.LastName = lastName;
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public override void AddComment(string comment)
        {
            throw new NotImplementedException();
        }

        public override void RemoveComment(int number)
        {
            throw new NotImplementedException();
        }
    }
}