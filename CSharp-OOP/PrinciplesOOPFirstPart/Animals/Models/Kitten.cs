namespace Animals.Models
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age)
        {
            this.Gender = Gender.Female;
        }
    }
}