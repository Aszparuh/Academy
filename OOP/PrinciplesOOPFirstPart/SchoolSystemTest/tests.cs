namespace SchoolSystemTest
{
    using SchoolSysytemLib.Models;

    class tests
    {
        static void Main()
        {
            Student testPerson = new Student("Gosho", "Petrov");

            System.Console.WriteLine(testPerson);
        }
    }
}