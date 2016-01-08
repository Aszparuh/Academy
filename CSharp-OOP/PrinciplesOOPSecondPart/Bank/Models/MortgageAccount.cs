namespace Bank.Models
{
    using Bank.Interfaces;
    using Bank.Enums;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer owner, decimal balance, decimal interestRate)
            : base(owner, balance, interestRate)
        {
            base.Type = AccountType.Mortgage;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Owner is CompanyCustomer)
            {
                if (months <= 12)
                {
                    return months * (this.Balance * 0.5m);
                }
                else
                {
                    return (12 * (this.Balance * 0.5m)) + ((months - 12) * ((this.InterestRate / 100) * this.Balance));
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0.0m;
                }
                else
                {
                    return (months - 6) * ((this.InterestRate / 100.0m) * this.Balance);
                }
            }
        }
    }
}