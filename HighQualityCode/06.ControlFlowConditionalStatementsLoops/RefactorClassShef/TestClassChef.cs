namespace RefactorClassShef
{
    using RefactorClassShef.Models;

    public class TestClassChef
    {
        public static void Main()
        {
            var chef = new Chef();
            var salad = chef.CookSalad();
            System.Console.WriteLine(salad);
        }
    }
}