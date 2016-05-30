namespace SquareRoot
{
    using System;

    class Solve
    {
        static void Main()
        {
            try
            {
                float inputNumber = float.Parse(Console.ReadLine());
                if (inputNumber < 0)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine(string.Format("{0:0.000}", Math.Sqrt(inputNumber)));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
