namespace SchoolSystemTest
{
    using SchoolSysytemLib.Models;

    class tests
    {
        static void Main()
        {
            Teacher testPerson = new Teacher("Gosho", "Petrov");

            System.Console.WriteLine(testPerson);

            testPerson.AddComment(new Comment("AS"));
        }
    }
}