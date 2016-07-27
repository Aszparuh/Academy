namespace RefactorIfStatement
{
    using RefactorClassShef.Models;

    public class IfStatement
    {
        public static void Main()
        {
            /*Potato potato;
            //... 
            if (potato != null)
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                    Cook(potato);*/

            Vegetable testPotato = new Potato();

            if (testPotato != null)
            {
                bool notPeeled = !testPotato.IsPeeled;
                bool notRotten = !testPotato.IsRotten;

                if (notPeeled && notRotten)
                {
                    testPotato.Cook();
                }
            }
        }
    }
}