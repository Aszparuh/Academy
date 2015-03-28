namespace Animals.Models
{
    using Animals.Interfaces;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age) : base(name, age)
        { }

        public Dog(string name, int age, Gender gender) : base(name, age)
        {
            this.Gender = gender;
        }

        public override string MakeSound()
        {
            return "Bau";
        }
    }
}