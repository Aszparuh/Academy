namespace Bank.Models
{
    using System;
    using Bank.Interfaces;
    using Bank.Enums;

    public abstract class Account : IDepositable
    {
        private Customer owner;
        private decimal balance;
        private decimal interestRate;
        private DateTime dateCreated;
        private AccountType type;

        public Account(Customer owner, decimal balance, decimal interestRate)
        {
            this.Owner = owner;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.dateCreated = DateTime.Now;
        }

        public Customer Owner
        {
            get { return this.owner; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Every account should have owner");
                }

                this.owner = value; 
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }

        public DateTime DateCreated
        {
            get { return this.dateCreated; }
        }

        public AccountType Type
        {
            get { return this.type; }
            protected set { this.type = value; }
        }

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("{0} account, Owner: {1}, Balance: {2}", this.Type, this.Owner.Name, this.Balance);
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Cannot deposit negative amount.");
            }

            this.Balance += amount;
        }
    }
}