namespace Bank.Models
{
    using System;

    class IndividualCustomer : Customer
    {
        private string lastName;

        public IndividualCustomer(string firstName, string lastName) : base(firstName)
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
                    throw new ArgumentException("Last name cannot be null or empty.");
                }

                this.lastName = value;
            }
        }
    }
}