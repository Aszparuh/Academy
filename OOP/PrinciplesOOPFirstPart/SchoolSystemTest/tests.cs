namespace SchoolSystemTest
{
    using SchoolSysytemLib.Models;

    class tests
    {
        static void Main()
        {
            Person testPerson = new Person("Gosho", "Petrov");

            System.Console.WriteLine(testPerson.Name);

            testPerson.AddComment(new Comment("AS"));
        }
    }
}