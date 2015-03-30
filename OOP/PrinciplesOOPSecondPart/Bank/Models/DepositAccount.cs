namespace Bank.Models
{
    using System;
    using Bank.Interfaces;
    using Bank.Enums;

    class DepositAccount : Account, IWithdrawable, IDepositable
    {
        public DepositAccount(Customer owner, decimal balance, decimal interestRate)
            : base(owner, balance, interestRate)
        {
            base.Type = AccountType.Deposit;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance >= 1000.0m)
            {
                return months * ((this.InterestRate / 100.0m) * this.Balance);
            }

            else return 0.0m;
        }

        public void Wtihdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Ballance is less than amount.");
            }

            this.Balance -= amount;
        }
    }
}