namespace FrequentNumber
{
    using System;

    /*Write a program that finds the most frequent number in an array.
     {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}   4 (5 times)*/

    class FindNumber
    {
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter value for element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            int elementOccurance = 1;
            int mostFrequentElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                        if (counter > elementOccurance)
                        {
                            elementOccurance = counter;
                            mostFrequentElement = array[i];
                        }
                    }
                }

                counter = 0;
            }

            if (elementOccurance == 1)
            {
                Console.WriteLine("There aren't repeating elements.");
            }
            else
            {
                Console.WriteLine(mostFrequentElement + " " + "({0} times)", elementOccurance);
            }
        }
    }
}