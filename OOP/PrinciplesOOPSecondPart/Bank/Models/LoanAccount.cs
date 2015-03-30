namespace Bank.Models
{
    using System;
    using Bank.Interfaces;
    using Bank.Enums;

    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer owner, decimal balance, decimal interestRate)
            : base(owner, balance, interestRate)
        {
            base.Type = AccountType.Loan;
        }
        public override decimal CalculateInterest(int months)
        {
            if (this.Owner is IndividualCustomer)
            {
                months = Math.Max(0, months - 3);
            }
            else
            {
                months = Math.Max(0, months - 2);
            }

            return months * ((this.InterestRate / 100.0m) * this.Balance);
        }
    }
}