namespace Animals.Models
{
    using Animals.Interfaces;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age) : base(name, age)
        { }

        public Cat(string name, int age, Gender gender) : base(name, age)
        {
            this.Gender = gender;
        }

        public override string MakeSound()
        {
            return "Mew";
        }
    }
}