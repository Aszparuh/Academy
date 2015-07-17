namespace RefactorClassShef
{
    using RefactorClassShef.Models;

    class TestClassChef
    {
        static void Main()
        {
            var chef = new Chef();
            var salad = chef.CookSalad();
            System.Console.WriteLine(salad);
        }
    }
}