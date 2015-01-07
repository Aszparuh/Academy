using System;

/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.*/

class Employee
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Dow";
        byte age = 31;
        char gender = '\u006d';
        long idNumber = 8306112507;
        int employeeNumber = 27560000;

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("ID Number: " + idNumber);
        Console.WriteLine("Unique employee number: " + employeeNumber);
    }
}