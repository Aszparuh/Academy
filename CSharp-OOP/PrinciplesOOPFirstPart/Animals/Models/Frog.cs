namespace Animals.Models
{
    public class Frog : Animal
    {
        public Frog(string name, int age) : base(name, age)
        { }

        public Frog(string name, int age, Gender gender) : base(name, age)
        {
            this.Gender = gender;
        }

        public override string MakeSound()
        {
            return "Ribbit";
        }
    }
}