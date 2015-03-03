namespace SquareRoot
{
    using System;

    /*Write a program that reads an integer number and calculates and prints its square root.
      If the number is invalid or negative, print Invalid number.
      In all cases finally print Good bye.
      Use try-catch-finally block.*/

    class Calculate
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter number: ");
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double sqrRoot = Math.Sqrt(number);
                Console.WriteLine("The square root is: {0}", sqrRoot);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The chosen number must be possitive.");
            }
            catch (FormatException)
            {
                Console.WriteLine("The data you entered is not a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your number is too big or too small.");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}