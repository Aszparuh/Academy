namespace Persons.Models
{
    using Persons.Models.Enums;

    public class Person
    {
        public Person(Gender gender)
        {
            this.Gender = gender;
        }

        public Person(string name, Gender gender)
            : this(gender)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Name, this.Gender);
        }
    }
}