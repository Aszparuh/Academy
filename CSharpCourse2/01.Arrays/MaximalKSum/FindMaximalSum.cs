namespace MaximalKSum
{
    using System;

    /*Write a program that reads two integer numbers N and K and an array of N elements from the console.
      Find in the array those K elements that have maximal sum.*/

    class FindMaximalSum
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());

            int[] inputArray = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter value for element on position {0}: ", i);
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(inputArray);
            Console.Write("The biggest sum is:");
            Console.Write("{");
            for (int i = N - 1; K > 0; i--)
            {
                K--;

                Console.Write(inputArray[i] + " ");
            }

            Console.Write("}");
        }
    }
}