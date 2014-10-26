using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company's address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter phone number: ");
        long companyPhone = long.Parse(Console.ReadLine());
        Console.Write("Enter fax number: ");
        long companyFax = long.Parse(Console.ReadLine());
        Console.Write("Enter company's website: ");
        string companyWeb = Console.ReadLine();
        Console.Write("Enter manager's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter mananger's age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager's phone number: ");
        long managerPhone = long.Parse(Console.ReadLine());

        Console.WriteLine("The Company name is {0}", companyName);
        Console.WriteLine("Contacts: Address:{0} , Phone: {1}, Fax: {2} \n Website: {3} ", companyAddress, companyPhone, companyFax, companyWeb);
        Console.WriteLine("Manager: {0} {1} \n Phone: {2} Age: {3}" , firstName, lastName, managerPhone, age);
    }

}