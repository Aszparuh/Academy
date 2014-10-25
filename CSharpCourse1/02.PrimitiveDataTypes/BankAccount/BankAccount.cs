using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "John";
        string middleName = "Unknown";
        string lastName = "Doe";
        decimal moneyAmount = 234558m;
        string bankName = "Investmen Fund";
        string iban = "AL47 2121 1009 0000 0002 3569 8741";
        string bicCode = "AABAFI22";
        long creditCardOne = 371449635398431;
        long creditCardTwo = 343434343434343;
        long creditCardThree = 341134113411347;

        Console.WriteLine("This is the bank account of :" + " " + firstName +" "+ middleName + " " + lastName);
        Console.WriteLine("balance: " + moneyAmount);
        Console.WriteLine("Bank: " + bankName);
        Console.WriteLine("IBAN \\ BIC CODE: " + iban + " " + '\\' + " " + bicCode + "\r\n");
        Console.WriteLine("Credit Card Numbers: " + "\r\n");
        Console.WriteLine(creditCardOne);
        Console.WriteLine(creditCardTwo);
        Console.WriteLine(creditCardThree);
    }
}

