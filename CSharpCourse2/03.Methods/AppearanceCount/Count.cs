namespace AppearanceCount
{
    using System;

    /*Write a method that counts how many times given number appears in given array.
      Write a test program to check if the method is workings correctly.*/

    class Count
    {
        public static int TimesAppeared(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main()
        {
            //Console.Write("Enter the length of the array: ");
            //int length = int.Parse(Console.ReadLine());
            //int[] inputArray = new int[length];
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    Console.Write("Enter value on position {0}", i);
            //}
            //Console.Write("Enter number to look for: ");
            //int searchNumber = int.Parse(Console.ReadLine());
            int[] inputArray = new int[] { 1, 7, 7, 4, 7, 3, 7, 8, 9, 1, 23, 45, 67 };
            int searchNumber = 7;

            int timesAppeared = TimesAppeared(inputArray, searchNumber);
            if (timesAppeared > 0)
            {
                Console.WriteLine("The given number appeared {0} times in the array", timesAppeared);
            }
            else
            {
                Console.WriteLine("The given number was not found in the array.");
            }
        }
    }
}