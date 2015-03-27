namespace SchoolSysytemLib.Models
{
    public class Student : Person
    {
        private string uniqueClassNumber;

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            this.uniqueClassNumber = UniqueClassNumberStorage.CreateNewUniqueStud();
        }

        public string Number 
        {
            get { return this.uniqueClassNumber; }
        } 
    }
}