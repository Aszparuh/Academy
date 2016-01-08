namespace Animals.Models
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age)
        {
            this.Gender = Gender.Male;
        }
    }
}