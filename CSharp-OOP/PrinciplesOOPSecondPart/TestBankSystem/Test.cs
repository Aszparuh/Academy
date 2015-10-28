namespace TestBankSystem
{
    using System;
    using System.Collections.Generic;
    using Bank;
    using Bank.Models;

    class Test
    {
        static void Main()
        {
            Banks testBank = new Banks("Test bank");
            testBank.AddAccount(new LoanAccount(new IndividualCustomer("Ivan", "Petrov"), 1000, 5));
            testBank.AddAccount(new MortgageAccount(new CompanyCustomer("TestCompany LTD"), 5000, 6));
            testBank.AddAccount(new DepositAccount(new IndividualCustomer("Georgi", "Petrov"), 1500, 5));

            Console.WriteLine(testBank);
        }
    }
}