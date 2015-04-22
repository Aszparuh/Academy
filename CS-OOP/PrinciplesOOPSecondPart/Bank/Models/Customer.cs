namespace Bank.Models
{
    using System;
    
    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Account name cannot be null or empty.");
                }

                this.name = value;
            }
        }
    }
}