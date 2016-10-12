using System;

namespace SchoolSystem.Logic
{
    public class Person
    {
        private const int MinimalNameSymbols = 2;
        private const int MaximalNameSymbols = 31;
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can not be null or empty string");
                }
                else if (value.Length < MinimalNameSymbols || value.Length > MaximalNameSymbols)
                {
                    throw new ArgumentException("First name must be between 2 and 31 symbols");
                }
                else
                {
                    this.firstName = value;
                }
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can not be null or empty string");
                }
                else if (value.Length < MinimalNameSymbols || value.Length > MaximalNameSymbols)
                {
                    throw new ArgumentException("Last name must be between 2 and 31 symbols");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}
